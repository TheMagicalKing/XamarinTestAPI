using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using XamarinTestAPI.API;

namespace XamarinTestAPI.Services
{
    class ImageService
    {

        public static async Task<List<Image>> GetProductsAsync()
        {
            var url = "https://nh.pld.dk/wp-json/wc/v3/";
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            ApiKey keysGet = new ApiKey();


            var productsRawHtml = await client.GetStringAsync("products?consumer_key=" + keysGet.CKey + "&consumer_secret=" + keysGet.CSec);
            var productsRaw = Regex.Replace(productsRawHtml, "<.*?>", String.Empty);
            var serializer = new JsonSerializer();
            using (var tReader = new StringReader(productsRaw))
            {

                using (var jReader = new JsonTextReader(tReader))
                {
                    var products = serializer.Deserialize<List<Image>>(
                        jReader);

                    return products;

                }
            }
        }
    }
}
