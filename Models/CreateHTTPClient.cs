using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;


namespace View_York_Times.Models
{
    public class CreateHTTPClient
    {
        private string apiURL;
        private HttpClient client;
        public string responseMessage;
        public CreateHTTPClient(string apiURL)
        {
            this.apiURL = apiURL;
            this.client = new HttpClient();
        }


        public async Task getJsonData()
        {
            HttpResponseMessage response = await this.client.GetAsync(this.apiURL);
            response.EnsureSuccessStatusCode();
            this.responseMessage = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);
        }

    }
}
