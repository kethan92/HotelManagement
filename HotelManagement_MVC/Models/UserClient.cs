using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace HotelManagement_MVC.Models
{
    public class UserClient
    {
        private string Base_URL = "http://localhost:61740/api/users";

        public User checkUser(User user)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
               // HttpResponseMessage respone=client.GetAsync("User/")

            }
            catch
            {
                return null;
            }
            return null;
        }
    }
}