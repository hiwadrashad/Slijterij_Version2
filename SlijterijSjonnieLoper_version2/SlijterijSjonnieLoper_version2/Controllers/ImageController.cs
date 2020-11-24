using SlijterijSjonnieLoper_version2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlijterijSjonnieLoper_version2.Controllers
{
    public class ImageController : Controller
    {
        // GET: Others
        [Authorize]
        public ActionResult ViewImage(string id)
        {
            ViewImageViewModel viewImageViewModel = new ViewImageViewModel();
            viewImageViewModel.StoreString64ByteArrayFromImage = GeneralFunctions.ImageProcessing.ConvertHttpPostfilebaseto64bytearray(id);
            return View(viewImageViewModel);
        }
    }
}