using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.Models
{
    public class EmployeeModel
    {
        [Key]
        public string id { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]

        public string LastName { get; set; }

        [Display(Name = "Family name preposition")]

        public string PrepositionName { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [Display(Name = "Street name")]

        public string StreetName { get; set; }

        [Required]
        [Display(Name = "Street Number")]

        public int StreetNumber { get; set; }

        [Display(Name = "House number addition")]

        public string HouseNumberAddition { get; set; }

        [Required]
        [Display(Name = "Postal code")]

        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Birth date")]

        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name = "Birth place")]

        public string BirthPlace { get; set; }

        [Required]
        [Display(Name = "User name")]

        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]

        public string PassWord { get; set; }

        [Display(Name = "Working since")]

        public DateTime WorkingSince { get; set; }

        [Display(Name = "Profile picture")]
        [NotMapped]

        HttpPostedFileBase ProfilePicture { get; set; }

        [Display(Name = "Role")]

        public RoleEmployeeModel RoleEmployee { get; set; }

        //public EmployeeModel()
        //{
        //    this.WorkingSince = DateTime.Now;
        //    this.id = Guid.NewGuid().ToString();
        //}
    }
}