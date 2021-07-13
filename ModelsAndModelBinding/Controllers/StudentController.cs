using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ModelsAndModelBinding.Models;

namespace ModelsAndModelBinding.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet] //When user navigates to URL.
        public IActionResult Add()
        {
            return View();
        }
        //Gets called after user posts form data
        [HttpPost]
        public IActionResult Add(IFormCollection form)
        {
            //Need serverside validation for all data

            Student stu = new Student();
            stu.FullName = form["full_name"];
            stu.DateOfBirth = Convert.ToDateTime(form["dob"]);
            stu.EmailAddress = form["email"];
            stu.PhoneNumber = form["home_phone"];

            //Add to database

            ViewData["Added"] = stu.FullName + " added successfully";

            return View();
        }

        [HttpGet]
        public IActionResult AddWithBinding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWithBinding(Student s)
        {
            if(ModelState.IsValid) //True if all validation in model passes
            {
                ViewData["Message"] = $"{s.FullName} was added";
                //Add to database here...
            }
            return View();
        }
    }
}
