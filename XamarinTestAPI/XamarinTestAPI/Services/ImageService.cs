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
        

        static HttpClient client;

        static ImageService()
        {
            var url = "https://nh.pld.dk/wp-json/wc/v3/";
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
        }
        public static async Task<List<Image>> GetImageAsync()
        {
            ApiKey keysGet = new ApiKey();
            var imagesRawHtml = await client.GetStringAsync("products?consumer_key=" + keysGet.CKey + "&consumer_secret=" + keysGet.CSec);
            var imagesRaw = Regex.Replace(imagesRawHtml, "<.*?>", String.Empty);
            var serializer = new JsonSerializer();
            using (var tReader = new StringReader(imagesRaw))
            {
                using (var jReader = new JsonTextReader(tReader))
                {
                    var images = serializer.Deserialize<List<Image>>(
                        jReader);
                    return images;
                }
            }
        }
    }
}
