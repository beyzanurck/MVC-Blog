﻿using NBUY_REF.Services;
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
        IndexPageServices indexPageServices;

        public HomeController()
        {
            aboutPageService = new AboutPageService();
            contactPageServices = new ContactPageServices();
            indexPageServices = new IndexPageServices();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var index = indexPageServices.GetIndexPage();
            return View(index);
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