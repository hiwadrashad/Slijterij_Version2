using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlijterijSjonnieLoper_version2.ViewModels
{
    public class GenerateReservationFourBottlesViewModel
    {
        public List<SelectListItem> GenerateDropDownDataFromWhiskey { get; set; }

        public List<SelectListItem> GenerateDropDownDataFromCustomer { get; set; }

        [Required]
        public string StoreChoiceWhiskeyFromDropDownList { get; set; }

        [Required]
        public string StoreChoiceAmountOfBottlesWhiskeyFromDropDownList { get; set; }

        public string StoreChoiceWhiskeyFromDropDownList2 { get; set; }

        public string StoreChoiceAmountOfBottlesWhiskey2 { get; set; }

        public string StoreChoiceWhiskeyFromDropDownList3 { get; set; }

        public string StoreChoiceAmountOfBottlesWhiskey3 { get; set; }


        public string StoreChoiceWhiskeyFromDropDownList4 { get; set; }

        public string StoreChoiceAmountOfBottlesWhiskey4 { get; set; }

        [Required]
        public string StoreChoiceCustomerFromDropDownList { get; set; }

        public Models.BestellingModel bestellingModel { get; set; }
    }
}