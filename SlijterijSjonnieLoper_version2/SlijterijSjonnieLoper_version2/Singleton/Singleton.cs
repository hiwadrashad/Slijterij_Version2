using SlijterijSjonnieLoper_version2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.Singleton
{
    public static class Singleton
    {
        public static MockdataService MockInit { get; set; }
    }
}