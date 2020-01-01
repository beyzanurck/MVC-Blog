using NBUY_REF.Entities;
using NBUY_REF.Extentions;
using NBUY_REF.Models;
using NBUY_REF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NBUY_REF.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        private AboutPageService _aboutPageService;

        public AboutController()
        {
            _aboutPageService = new AboutPageService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var aboutModel = _aboutPageService.GetAbout().GetAboutViewModel();
            return View(aboutModel);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            var viewModel = _aboutPageService.GetAbout().GetAboutViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(AboutViewModel aboutViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Bu alan zorunludur kardeş");
                return View();

            }

            var aboutPage = aboutViewModel.GetAboutPage();
            _aboutPageService.UpdateAbout(aboutPage);
            return RedirectToAction("Edit");
        }

        


    }
}