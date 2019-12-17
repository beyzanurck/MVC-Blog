using NBUY_REF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NBUY_REF.Controllers
{
    public class HomeController : Controller
    {
        AboutPageService aboutPageService;
        ContactPageServices contactPageServices;

        public HomeController()
        {
            aboutPageService = new AboutPageService();
            contactPageServices = new ContactPageServices();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            var about = aboutPageService.GetAbout();
            return View(about);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            var contact = contactPageServices.GetContactPage();
            return View(contact);
        }
        
    }
}