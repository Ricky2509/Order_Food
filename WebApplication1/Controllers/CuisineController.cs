using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Filters;

namespace WebApplication1.Controllers
{
    public class CuisineController : Controller
    {
        
		//[Authorize]
		[Log]
        public ActionResult Search(string name= "TEST NAME")
        {
			throw new Exception("Something terrible has happened !");

			var message = Server.HtmlEncode(name);
			//return RedirectPermanent("http://crnobelo.com");
			//return RedirectToAction("Index", "Home", new { name = name });
			//return RedirectToRoute("Default", new { controller= "Home", action ="About" });
			//return File(Server.MapPath("~/Content/site.css"), "text/css");
			//return Json(new { Message = message, Name = "Ricky", Location = "Ohrid,Macedonia" }, JsonRequestBehavior.AllowGet);

			return Content(message);
        }
		
	}
}