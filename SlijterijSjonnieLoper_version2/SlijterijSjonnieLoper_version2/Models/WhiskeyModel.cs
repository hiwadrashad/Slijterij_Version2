using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.Models
{
    public class WhiskeyModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public string id { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]
        [Display(Name = "Age in years")]
        public int age { get; set; }

        [Required]
        [Display(Name = "Production site")]
        public ProductionSite ProductionSite { get; set; }

        [Required]
        [Display(Name = "Alcohol percentage")]

        public AlcoholPercentagesModel alcoholPercentages { get; set; }

        [Required]

        public TypesOfWhiskeyModel typesOfWhiskey { get; set; }

        [Required]
        [NotMapped]
        [Display(Name = "Label")]

        public HttpPostedFileBase LabelImage { get; set; }

        public string Storeimageas64ByteString { get; set; }

        [Required]

        public double Price { get; set; }

        [Required]
        [Display (Name = "Number of bottles on storage")]

        public int NumberOfBottlesOnStorage { get; set; }

        [Required]
        [Display(Name = "Number of bottles reserved")]

        public int NumberOfBottlesReserved { get; set; }

        //   public List<CustomerModel> Reservations { get; set; }

        [Display (Name = "Is removed")]

        public bool IsRemoved { get; set; }

        public WhiskeyModel()
        {
            this.id = Guid.NewGuid().ToString();
        //    Reservations = new List<CustomerModel>();
        }

    }
}