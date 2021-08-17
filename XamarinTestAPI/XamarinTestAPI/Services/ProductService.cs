using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Auth;
using XamarinTestAPI.API;

namespace XamarinTestAPI.Services
{
    class ProductService
    {
        private const string WISHLIST_FILE = "wishlist.json";
        private const string cKey = "ck_5ea2e897c4d94fe81218cd4fd8682f21cfae1920";
        private const string cSec = "cs_78548c346f08940263a5b4fda60337a0c9c5f22d";


        public static List<Product> WishList
        {
            get;
            set;
        }

        
        static HttpClient client;
        
        static ProductService()
        {
            var url = "https://nh.pld.dk/wp-json/wc/v3/";
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
        }

        public static async Task<List<Product>> GetProductsAsync()
        {
            ApiKey keysGet = new ApiKey();
            
            
            var productsRawHtml = await client.GetStringAsync("products?consumer_key="+keysGet.CKey+"&consumer_secret="+keysGet.CSec);
            var productsRaw = Regex.Replace(productsRawHtml, "<.*?>", String.Empty);
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
