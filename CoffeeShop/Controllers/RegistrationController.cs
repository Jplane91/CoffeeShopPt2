using System;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;
using System.Linq;
using System.Collections.Generic;


namespace CoffeeShop.Controllers
{
    public class RegistrationController:Controller
    {
        public IActionResult Index()
        {
            return View(new PersonModel() { });
        }

        [HttpPost]
        public IActionResult EnrollUser(PersonModel person)
        {
     

            if (ModelState.IsValid)
            {
                return View(person);
            }
            else
            {
                return View("Index", person);
            }
        }
    }
}
