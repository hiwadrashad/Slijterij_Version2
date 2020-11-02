using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.Models
{
    public enum TypesOfWhiskeyModel
    {
        Irish,
        Scotch,
        Japanese,
        Canadian,
        Bourbon,
        Tennessee,
        Rye,
        Blended,
        [Display(Name = "Single Malt")]
        Single
    }
}