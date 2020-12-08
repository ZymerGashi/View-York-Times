using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using View_York_Times.Models;

namespace View_York_Times.Controllers
{
    public class BestSellersController : Controller
    {
        public async Task<IActionResult> Index()
        {
            CreateHTTPClient client = new CreateHTTPClient("https://api.nytimes.com/svc/books/v3/lists/current/hardcover-fiction.json?api-key=kmjdapKyv3FWAQQCLlmamRwmfFm1t7dX");


            await client.getJsonData();

            var JsonResponse = JsonConvert.DeserializeObject<Root>(client.responseMessage);


            ViewBag.Message = JsonResponse;
            return View();
        }
    }
}
