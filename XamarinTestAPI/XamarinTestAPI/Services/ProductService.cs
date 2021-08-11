using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XamarinTestAPI.Services
{
    class ProductService
    {
        private const string WISHLIST_FILE = "wishlist.json";
        static HttpClient client;

        public static List<Product> WishList
        {
            get;
            set;
        }

        static ProductService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://api.thecatapi.com/v1/");

        }

        public static async Task<List<Product>> GetProductsAsync()
        {
            var productsRaw = await client.GetStringAsync("images/search/");

            var serializer = new JsonSerializer();
            using (var tReader = new StringReader(productsRaw))
            {
                using (var jReader = new JsonTextReader(tReader))
                {
                    var products = serializer.Deserialize<List<Product>>(
                        jReader);

                    return products;
                }
            }
        }

        public static async Task SaveWishList()
        {
            if (WishList != null && WishList.Count > 0)
            {
                //Save Products to Wish List
            }
        }

        public static async Task LoadWishList()
        {
            //Load items from wish list
        }
    }
}
