using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.Models
{
    public enum AlcoholPercentagesModel
    {
        [Display(Name = "38")]
        thirthyeight,
        [Display(Name = "40")]
        forty,
        [Display(Name = "42")]
        fortytwo,
        [Display(Name = "44")]
        fortyfour,
        [Display(Name = "46")]
        fortysix,
        [Display(Name = "48")]
        fortyeight
    }
}