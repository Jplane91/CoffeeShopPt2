using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class PersonModel
    {

      
        public string Prefix { get; set; }

        [Required(ErrorMessage = "Must enter in a name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Must enter in a last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Must enter in a username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Must enter in an email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Must confirm email")]
        [Compare("Email", ErrorMessage = "The emails do not match.")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Must enter in a password")]
        [RegularExpression(@"^[a-zA-Z]\w{3,14}$", ErrorMessage = "Password must between 4-15 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Must confirm password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
        public int Age { get; set; }

    }
}
