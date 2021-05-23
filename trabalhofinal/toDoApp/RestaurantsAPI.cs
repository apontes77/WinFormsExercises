using Newtonsoft.Json;
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

        public static async Task<string> PostRestaurant(string restaurantNameParam, string restaurantSloganParam)
        {

            Restaurant restaurant = new Restaurant();
            restaurant.restaurantName = restaurantNameParam;
            restaurant.sloganRestaurant = restaurantSloganParam;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(restaurant);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(baseURL, content);

            }

            return string.Empty;
        }
    }
}
