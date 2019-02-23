using Globaldev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Globaldev.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            var patientList = new List<Patient>{
                            new Patient() { ID= 1 , fName = "Fatimah", mName = "John",
                                lName = "Al-khateeb"  ,DOB = new DateTime(1995, 1, 13) , gender="Female" ,
                                email = "fatimah@gmail.com" , lastCheck ="2:00pm" , status ="not in hospital" ,
                                Active ="true"  , CreationDate = new DateTime(2000, 1, 13) , CreatedBy="Ahmad"  } ,
                            
                      
                        };
            // Get the students from the database in the real application

            return View(patientList);
        }
    }
}