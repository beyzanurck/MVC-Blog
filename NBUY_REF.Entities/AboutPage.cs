using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_REF.Entities
{
    public class AboutPage
    {
        public int Id { get; set; }

        public string TitleName { get; set; }

        public string AboutDescription { get; set; }
    }

    public class ContactPage
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string GitHubProfile { get; set; }
    }
}
