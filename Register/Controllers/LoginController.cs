﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PasswordSecurity;

namespace Register.Controllers
{
    public class LoginController : Controller
    {
		private RegisterContext db = new RegisterContext();
		// GET: Login
		public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Login(string userName, string password)
		{
			if (userName != null && password != null)
			{
				var model = db.Users.Where(x => x.UserName == userName).SingleOrDefault();
				if (model==null)
				{
					return Content("User Name or Password is not Valid");
				}
				bool result = PasswordStorage.VerifyPassword(password, model.Password);
				if (result)
				{
					return RedirectToAction("Index","Users");
				}
			}
			return View();
		}
	}
}