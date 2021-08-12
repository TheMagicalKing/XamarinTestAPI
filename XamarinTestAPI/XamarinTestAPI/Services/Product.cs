using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinTestAPI.Services
{

    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string permalink { get; set; }
        public string description { get; set; }
        public string short_description { get; set; }
        public List<Image> images { get; set; }

    }
    public class Image
    {
        public int id { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_created_gmt { get; set; }
        public DateTime date_modified { get; set; }
        public DateTime date_modified_gmt { get; set; }
        public string src { get; set; }
        public string name { get; set; }
        public string alt { get; set; }
    }

}
