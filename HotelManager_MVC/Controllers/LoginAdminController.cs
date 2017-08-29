using HotelManager_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManager_MVC.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: LoginAdmin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(User user)
        {

            if (ModelState.IsValid)
            {

                var result = new UserClient().checkUser(user);

                if (result != null)
                {
                    User _user = new HotelManager_MVC.Models.User();
                    _user.username = result.username;
                    _user.password = result.password;
                    _user.groupid = result.groupid;
                    _user.id = result.id;
                    // Session.Add(Areas.Client.Common.CommonConstants.ADMIN_SESSION, _user);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Sai tên tài khoản hoặc mật khẩu!");
                    return View("Index");
                }
            }
            return View("Index");
        }
    }
}