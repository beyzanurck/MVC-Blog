using NBUY_REF.DAL.Database;
using NBUY_REF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_REF.DAL.Management
{
    public class IndexManagement
    {
        private ProjeContext database;

        public IndexManagement()
        {
            database = new ProjeContext();
        }

        public IndexPage GetIndexPage()
        {
            var model = database.IndexPage.FirstOrDefault();
            return model;
        }
    }
}
