using System;
using System.Collections.Generic;
using System.Text;
using XamarinTestAPI.Services;

namespace XamarinTestAPI.Design
{
    public class ProductModel
    {
        public static Product Product
        {
            get
            {
                return new Product
                {
                    id = "120",
                    url = "https://reddit.com/",
                    width = 120
                };
            }
        }
    }
}
