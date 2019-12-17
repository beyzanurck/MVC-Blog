using NBUY_REF.DAL.Database;
using NBUY_REF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_REF.DAL.Management
{
    public class ContactManagement
    {
        private ProjeContext database;

        public ContactManagement()
        {
            database = new ProjeContext();
            
        }

        public ContactPage GetContactPage()
        {
            var model = database.ContactPage.FirstOrDefault();
            return model;
        }
    }
}
