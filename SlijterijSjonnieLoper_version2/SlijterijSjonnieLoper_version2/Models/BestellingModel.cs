using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.Models
{
    public class BestellingModel
    {
        [Key]
        public string id { get; set; }

        [Required]
 
        public WhiskeyModel Whiskey { get; set; }

        [Required]

        public CustomerModel Customer { get; set; }

        [Required]
        [Display(Name = "Amount of bottles")]

        public int AmountOfBottles { get; set; }

        [Display(Name = "Date of order reservation")]

        public DateTime DateOfReservation { get; set; }

        [Display(Name = "Date of completion order")]

        public DateTime DateOfCompletionOrder { get; set; }

        [Required]
        [Display(Name = "Order Completed?")]
        public bool CompletedOrder { get; set; }
        [Required]
        [Display(Name = "City to send to")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Street name to send to")]

        public string StreetName { get; set; }

        [Required]
        [Display(Name = "Street Number to send to")]

        public int StreetNumber { get; set; }

        [Display(Name = "House number addition to send to")]

        public string HouseNumberAddition { get; set; }

        [Required]
        [Display(Name = "Postal code to send to")]

        public string PostalCode { get; set; }

        //public BestellingModel()
        //{
        //    this.id = Guid.NewGuid().ToString();
        //    this.DateOfReservation = DateTime.Now;
        //}
    }
}