using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace HotelManager_MVC.Models
{
    public class UserClient
    {
        private string Base_URL = "http://localhost:61740/api/users";

        public User checkUser(User user)
        {
            List<User> user_ = new List<User>();
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                // HttpResponseMessage respone=client.GetAsync("User/")
                HttpResponseMessage response = client.GetAsync("Users/UserLogin?username=" + user.username + "&password=" + user.password).Result;
                if (response.IsSuccessStatusCode)
                {
                    var userResponse = response.Content.ReadAsStringAsync().Result;
                   // user_ = JsonConvert.DeserializeObject<List<User>>(userResponse);
                    return null;
                }

                return null;
            }
            catch
            {
                return null;
            }

        }
    }
}