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
       
        // GET: api/Users/5
        [ResponseType(typeof(User))]
        [HttpGet]
        public IHttpActionResult UserLogin(string username, string password)
        {
            var result = db.Users.FirstOrDefault(x => x.username.Equals(username) && x.password.Equals(password));
            if (result == null)
            {
                return NotFound();
            }


            return Ok(result);
        }
        [HttpGet]
        public IHttpActionResult getGroupID(int id)
        {
            var result = db.Users.Where(x => x.id == id).Select(x => x.groupid).ToList();
            if(result==null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
