using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlijterijSjonnieLoper_version2.ViewModels
{
    public class GenerateReservationViewModel
    {
        public List<SelectListItem> GenerateDropDownDataFromWhiskey { get; set; }

        public List<SelectListItem> GenerateDropDownDataFromCustomer { get; set; }

        [Required]
        public string StoreChoiceWhiskeyFromDropDownList { get; set; }

        [Required]
        public string StoreChoiceAmountOfBottlesWhiskey { get; set; }

        [Required]
        public string StoreChoiceCustomerFromDropDownList { get; set; }

        public Models.BestellingModel bestellingModel { get; set; }


    }
}