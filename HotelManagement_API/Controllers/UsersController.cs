using HotelManagement_API.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace HotelManagement_API.Controllers
{
    public class UsersController : ApiController
    {
        private RoomManagerEntities db = new RoomManagerEntities();
        public IQueryable<User> Get()
        {
            return db.Users;
        }
        /*
        public HttpRequestMessage checkLogin(string username,string password)
        {
            User user = db.Users.FirstOrDefault(x => x.username.Equals(username) & x.password.Equals(password));
            if (user==null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        */
        // GET: api/Users/5
        [ResponseType(typeof(User))]
        [HttpGet]
        public IHttpActionResult UserLogin(string username, string password)
        {
            User result = db.Users.FirstOrDefault(x => x.username.Equals(username) && x.password.Equals(password));
            if (result == null)
            {
                return NotFound();
            }
            User _user = new User();

            return Ok(result);
        }
    }
}
