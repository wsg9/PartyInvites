using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "<H1>Hello World!</H1>";
        //}

        
        public ViewResult Index()
        {
            // return the index.cshtml (page or view) under the
            // Views/Home
            return View("Index");
        }

        // http://localhost:55674/Home/RsvpForm
        [HttpGet]  // to 

        public ViewResult RsvpForm()
        {
            return View("RsvpForm");
        }

        [HttpPost]  // to receive form data, POST

        public ViewResult RsvpForm(GuestResponse response)
        {
            return View("Thanks");
        }
    }
}