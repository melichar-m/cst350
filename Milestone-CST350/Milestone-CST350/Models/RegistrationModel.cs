using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Milestone_CST350.Models
{
    public class RegistrationModel
    {
        public RegistrationModel()
        {

        }
        public RegistrationModel(
            string firstName,
            string lastName,
            string sex,
            int age,
            string state,
            string email,
            string username,
            string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Age = age;
            State = state;
            Email = email;
            Username = username;
            Password = password;
        }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }

        [Display(Name = "Sex")]
        [Required(ErrorMessage = "Please select your sex.")]
        public string Sex { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Please enter your age.")]
        [Range(1, 120, ErrorMessage = "Please enter a valid age.")]
        public int Age { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please select your state.")]
        public string State { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please enter a username.")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter a password.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        public string Password { get; set; }
    }
}
