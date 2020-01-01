using NBUY_REF.Entities;
using NBUY_REF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NBUY_REF.Extentions
{
    public static class AboutExtentions
    {
        public static AboutViewModel GetAboutViewModel(this AboutPage aboutPage)
        {
            AboutViewModel aboutViewModel = new AboutViewModel();
            aboutViewModel.Id = aboutPage.Id;
            aboutViewModel.Title = aboutPage.TitleName;
            aboutViewModel.Description = aboutPage.AboutDescription;
            return aboutViewModel;
        }

        public static AboutPage GetAboutPage(this AboutViewModel aboutViewModel)
        {
            AboutPage aboutPage = new AboutPage
            {
                Id=aboutViewModel.Id,
                TitleName = aboutViewModel.Title,
                AboutDescription = aboutViewModel.Description                
            };

            return aboutPage;
        }
    }
}