using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinTestAPI.Services
{
    public class Product
    {
        public List<object> breeds { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}
