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
        public ActionResult Details(int id)
        {
            PatientContext patientContext = new PatientContext();
            Patient patient = patientContext.Patients.Single(pat => pat.ID == id); 
            return View(patient);
        }

        
    }
}