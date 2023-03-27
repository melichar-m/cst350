using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        public AppointmentModel(
            string patientName,
            DateTime dateTime,
            decimal patientNetWorth,
            string doctorName,
            int painLevel,
            string street,
            string city,
            string zipCode,
            string email,
            string phone)
        {
            this.patientName = patientName;
            this.dateTime = dateTime;
            this.patientNetWorth = patientNetWorth;
            this.doctorName = doctorName;
            this.painLevel = painLevel;
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.email = email;
            this.phone = phone;
        }

        public AppointmentModel()
        {
        }

        [Required]
        [DisplayName("Patient's full name")]
        [StringLength(20, MinimumLength = 4)]
        public string patientName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Appointment Date and Time")]
        public DateTime dateTime { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Patient's Net Worth")]
        [Range(90000, double.PositiveInfinity, ErrorMessage = "Doctors refuse to see patients unless their net worth is more than $90,000.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Invalid currency format.")]
        public decimal patientNetWorth { get; set; }


        [Required]
        [DisplayName("Pain Level")]
        [Range(6,10,ErrorMessage="Doctors refuse to see patients unless their pain is a 6 or higher.")]
        public int painLevel { get; set; }

        [Required]
        [DisplayName("Street")]
        public string street { get; set; }

        [Required]
        [DisplayName("City")]
        public string city { get; set; }

        [Required]
        [DisplayName("ZIP code")]
        public string zipCode { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        public string email { get; set; }

        [Required]
        [Phone]
        [DisplayName("Phone")]
        public string phone { get; set; }
        [DisplayName("Doctor's Name")]
        public string doctorName { get; set; }
    }
}
