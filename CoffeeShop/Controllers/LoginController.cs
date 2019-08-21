using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoffeeShop.Controllers
{
    public class LoginController:Controller
    {
        List<PersonModel> registeredUsers = new List<PersonModel>();

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult RegisterUser()
        {
            return View(new PersonModel());
        }
        [HttpPost]
        public IActionResult RegisterUser(PersonModel user)
        {
            if (ModelState.IsValid)
            {

                string usersJson = HttpContext.Session.GetString("LoginSession");
                if (usersJson != null)
                { 
                    registeredUsers = JsonConvert.DeserializeObject<List<PersonModel>>(usersJson);
                }

                registeredUsers.Add(user);
                HttpContext.Session.SetString("LoginSession", JsonConvert.SerializeObject(registeredUsers));
                return View("UserList", registeredUsers);
            }
            return View(user);
        }
        public IActionResult UserList()
        {
            return View();
        }
    }
}
