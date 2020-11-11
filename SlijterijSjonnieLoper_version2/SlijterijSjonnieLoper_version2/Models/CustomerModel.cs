using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.Models
{
    public class CustomerModel
    {
 
        [Key]
        public string id { get; set; }

        [Required]
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "First name")]

        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]

        public string LastName { get; set; }

        [Display(Name = "Preposition name")]

        public string PrepositionName { get; set; }

        [Required]

        public string City { get; set; }

        [Required]
        [Display(Name = "Street name")]

        public string StreetName { get; set; }

        [Required]
        [Display(Name = "Street number")]

        public int StreetNumber { get; set; }

        [Display(Name = "House number addition")]

        public string HouseNumberAddition { get; set; }

        [Required]
        [Display(Name = "Postal number")]

        public string PostalNumber { get; set; }

        [Display(Name = "Birth place")]

        public string BirthPlace { get; set; }

      // [Display(Name = "Whiskeys reserved")]

      // public List<BestellingModel> Whiskeys { get; set; }

        //public CustomerModel()
        //{
        //    this.id = Guid.NewGuid().ToString();
        ////    Whiskeys = new List<BestellingModel>();
        //}


    }
}