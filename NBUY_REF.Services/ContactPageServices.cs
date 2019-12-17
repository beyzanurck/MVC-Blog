using NBUY_REF.DAL.Management;
using NBUY_REF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_REF.Services
{
    public class ContactPageServices
    {
        private ContactManagement contactManagement;

        public ContactPageServices()
        {
            contactManagement = new ContactManagement();
        }

        public ContactPage GetContactPage()
        {
            var model = contactManagement.GetContactPage();

            return model;
        }


    }
}
