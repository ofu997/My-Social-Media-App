using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Register.Models;

namespace Register.Controllers
{
    public class RegisterController : Controller
    {
		private RegisterContext db = new RegisterContext();
        // GET: Register
        public ActionResult Index()
        {
			var model = db.Interests.ToList();
			ViewBag.interest = new MultiSelectList(model, "Id", "Name");
            return View();
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Register(User user, int[] Interests)
		{
			if (Interests!=null)
			{
				foreach (var item in Interests)
				{
					Interest interest = db.Interests.Find(item);
					user.Interests.Add(interest);
				}
				db.Users.Add(user);
				db.SaveChanges();
				return RedirectToAction("Index", "Users");
			}
			return RedirectToAction("Index");
		}
    }
}