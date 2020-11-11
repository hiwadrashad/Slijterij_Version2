using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlijterijSjonnieLoper_version2.ViewModels
{
    public class ChangeDataReservationViewModel
    {
        public List<SelectListItem> GenerateDropDownDataFromWhiskey { get; set; }

        public List<SelectListItem> GenerateDropDownDataFromCustomer { get; set; }

        [Required]
        [Display(Name = "Whiskey")]
        public string StoreChoiceWhiskeyFromDropDownList { get; set; }

        [Required]
        [Display(Name = "Amount of bottles")]
        public int StoreChoiceAmountOfBottlesWhiskey { get; set; }

        [Required]
        [Display(Name = "Customer")]
        public string StoreChoiceCustomerFromDropDownList { get; set; }

        public Models.BestellingModel bestellingModel { get; set; }
    }
}