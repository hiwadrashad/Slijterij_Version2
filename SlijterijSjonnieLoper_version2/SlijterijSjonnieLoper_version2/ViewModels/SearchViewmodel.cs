using SlijterijSjonnieLoper_version2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.ViewModels
{
    public class SearchViewModel
    {
        public string SearchQuery { get; set; }

        public IEnumerable<WhiskeyModel> whiskeyModels { get; set; }
    }
}