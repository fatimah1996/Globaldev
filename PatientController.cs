using Globaldev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Globaldev.Controllers
{
    public class PatientController : Controller
    { IList<Patient> patientList = new List<Patient>{
                            new Patient() { ID= 1 , fName = "Fatimah", mName = "John",
                                lName = "Al-khateeb"  ,DOB = new DateTime(1995, 1, 13) , gender="Female" ,
                                email = "fatimah@gmail.com" , lastCheck ="2:00pm" , status ="not in hospital" ,
                                Active ="true"  , CreationDate = new DateTime(2000, 1, 13) , CreatedBy="Ahmad"  } ,
                            
                      
                        };
        [HttpGet]
        public ActionResult Edit(int Id)
        {

            var ptn = patientList.Where(s => s.ID == Id).FirstOrDefault();

            return View(ptn);
        }

        [HttpPost]
        public ActionResult Edit(Patient pat)
        {
            //write code to update patient data
            for (int i = 0; i <= patientList.Count; i++)
            { patientList.Add(pat.fName); }



            return RedirectToAction("Index");
        }


        // GET: Student
        public ActionResult Index()
        {
            return View(patientList);
        }

        //Get the student from studentList sample collection for demo purpose.
        //Get the student from the database in the real application

       

    }
}