
using HotelManagementMVC_ClientWithAngularJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagementMVC_ClientWithAngularJS.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        // check login
        /*
        public ActionResult Alogin(HotelManagementMVC_ClientWithAngularJS.Models.User user)
        {
            if(ModelState.IsValid)
            {
                var result = new HotelManagementMVC_ClientWithAngularJS.Models.UserClient().checkUser(user);
                if(result!=null)
                {
                    HotelManagementMVC_ClientWithAngularJS.Models.User _user = new HotelManagementMVC_ClientWithAngularJS.Models.User();
                    _user.username = user.username;
                    _user.password = user.password;
                    _user.id = user.id;
                    _user.groupid = user.groupid;


                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Sai tên tài khoản hoặc mật khẩu");
                    return View("Index");
                }
            }
            return View("Index");
        }
        */
    }
}