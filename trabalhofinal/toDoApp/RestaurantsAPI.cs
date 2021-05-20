using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace toDoApp
{
    public static class RestaurantsAPI
    {
        private static readonly string baseURL = "http://localhost:8082/api/v1/restaurants";

        public static async Task<string> GetAll()
        {
            using(HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "/all"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> PostRestaurant(string restaurantName, string restaurantSlogan)
        {


            var inputData = new Dictionary<string, string>
            {
                {"nameRestaurant", restaurantName },
                {"sloganRestaurant", restaurantSlogan }
            };

            var input = new FormUrlEncodedContent(inputData);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL, input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
    }
}
