using NBUY_REF.DAL.Management;
using NBUY_REF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_REF.Services
{
    public class IndexPageServices
    {
        private IndexManagement ındexManagement;

        public IndexPageServices()
        {
            ındexManagement = new IndexManagement();
        }

        public IndexPage GetIndexPage()
        {
            var model = ındexManagement.GetIndexPage();
            return model;
        }
    }
}
