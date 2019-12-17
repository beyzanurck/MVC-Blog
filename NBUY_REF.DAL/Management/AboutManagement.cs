using NBUY_REF.DAL.Database;
using NBUY_REF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_REF.DAL.Management
{
    public class AboutManagement
    {

        private ProjeContext database;

        public AboutManagement()
        {
            database = new ProjeContext();
        }

        public AboutPage GetAboutPage()
        {
            var aboutPage = database.AboutPage.FirstOrDefault();
            return aboutPage;
        }


    }
}
