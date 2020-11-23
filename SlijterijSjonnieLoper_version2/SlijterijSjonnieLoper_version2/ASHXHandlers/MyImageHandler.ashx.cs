using Microsoft.Ajax.Utilities;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto.Paddings;
using SlijterijSjonnieLoper_version2.DAL;
using SlijterijSjonnieLoper_version2.GeneralFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.ASHXHandlers
{
    /// <summary>
    /// Summary description for MyImageHandler
    /// </summary>
    public class MyImageHandler : IHttpHandler
    {
        private IDataService _dataService = MockdataService.GetMockdataService();
        //private IDataService _dataService = ApplicationDataService.GetService();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "Image/png";
            var param = context.Request.QueryString["id"];
            int id = 0;
            if (param != null && int.TryParse(param, out id))
            {
                byte[] image = null;
                image = ImageProcessing.ConvertToBytes(_dataService.GetAllWhiskeys().Where(a => a.id.Equals(id)).FirstOrDefault().LabelImage);
                TimeSpan cacheTime = new TimeSpan(1, 0, 0);
                context.Response.Cache.VaryByParams["*"] = true;
                context.Response.Cache.SetExpires(DateTime.Now.Add(cacheTime));
                context.Response.Cache.SetMaxAge(cacheTime);
                context.Response.Cache.SetCacheability(HttpCacheability.Public);
                context.Response.BinaryWrite(image);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}