using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Globaldev.Models
{
    public class Patient
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string fName { get; set; }
        public string mName { get; set; }
        public string lName { get; set; }
        public DateTime DOB ;
        public string gender { get; set; }
        public string email { get; set; }
        public string lastCheck { get; set; }
        public string status { get; set; }
        public string Active { get; set; }
        public DateTime CreationDate;
        public string CreatedBy { get; set; }
    
    }
}