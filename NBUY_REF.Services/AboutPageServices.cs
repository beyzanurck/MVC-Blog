using NBUY_REF.DAL.Management;
using NBUY_REF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_REF.Services
{
    public class AboutPageService
    {
        private AboutManagement aboutManagement;

        public AboutPageService()
        {
            aboutManagement = new AboutManagement();

        }

        public AboutPage GetAbout()
        {
            var aboutPage = aboutManagement.GetAboutPage();
            return aboutPage;
        }
    }

    
}
