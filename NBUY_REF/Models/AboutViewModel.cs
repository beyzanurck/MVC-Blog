using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NBUY_REF.Models
{
    public class AboutViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Başlık")]
        [Required]
        //[MaxLength(20, ErrorMessage = "{0} için Max {1} kaarakter uzunluğunda veri girişi")]
        //[MinLength(5, ErrorMessage = "Min 5 kaarakter uzunluğunda veri girişi")]
        //[Phone]
        //[EmailAddress]
        public string Title { get; set; }

        [Required]
        
        [Display(Name = "İçerik")]
        public string Description { get; set; }

        
    }
}