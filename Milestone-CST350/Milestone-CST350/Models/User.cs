using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milestone_CST350.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(32)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(32)]
        public string LastName { get; set; }

        [Required]
        public string Sex { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }

}