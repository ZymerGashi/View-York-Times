using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace View_York_Times.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Link
    {
        public string type { get; set; }
        public string url { get; set; }
        public string suggested_link_text { get; set; }
    }

    public class Multimedia
    {
        public string type { get; set; }
        public string src { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Result
    {
        public string display_title { get; set; }
        public string mpaa_rating { get; set; }
        public int critics_pick { get; set; }
        public string byline { get; set; }
        public string headline { get; set; }
        public string summary_short { get; set; }
        public string publication_date { get; set; }
        public string opening_date { get; set; }
        public string date_updated { get; set; }
        public Link link { get; set; }
        public Multimedia multimedia { get; set; }
    }

    public class RootMovieReview
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public bool has_more { get; set; }
        public int num_results { get; set; }
        public List<Result> results { get; set; }

        public int numberOfRows()
        {

            return results.Count % 3 == 0 ? results.Count / 3 : (results.Count / 3) + 1;
        }
    }
}
