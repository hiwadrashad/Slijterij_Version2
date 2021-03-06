﻿using SlijterijSjonnieLoper_version2.DAL;
using SlijterijSjonnieLoper_version2.Extensions;
using SlijterijSjonnieLoper_version2.Models;
using SlijterijSjonnieLoper_version2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlijterijSjonnieLoper_version2.Controllers
{
    public class WhiskeyController : Controller
    {
        // GET: Whiskey

        private IDataService _dataService = MockdataService.GetMockdataService();
        //private IDataService _dataService = ApplicationDataService.GetService();

        [Authorize]
        public ActionResult WhiskeySearchOverview(string searching)
        {
            //return View(_dataService.SearchWhiskeys(searching));
            return View();
        }

        [Authorize]
        public ActionResult WhiskeyOverView()
        {
            foreach (var item in _dataService.GetAllWhiskeys())
            {
                item.Storeimageas64ByteString = GeneralFunctions.ImageProcessing.ConvertHttpPostfilebaseto64bytearray(item.id);
            }
            foreach (var item in _dataService.GetAllWhiskeys())
            {
                System.Drawing.Image.FromStream(item.LabelImage.InputStream);
            }
            SearchViewModel searchViewModel = new SearchViewModel();
            searchViewModel.whiskeyModels = _dataService.GetAllWhiskeys();
            return View(searchViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult WhiskeyOverView(SearchViewModel model)
        {
            //foreach (var item in model.whiskeyModels)
            //{
            //    item.Storeimageas64ByteString = GeneralFunctions.ImageProcessing.ConvertHttpPostfilebaseto64bytearray(item.id);
            //}
            try
            {
                SearchViewModel searchViewModel = new SearchViewModel();
                searchViewModel.whiskeyModels = _dataService.SearchWhiskeys(model.SearchQuery);
                return View(searchViewModel);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                SearchViewModel searchViewModel = new SearchViewModel();
                this.AddNotification("Please enter a valid value", NotificationType.ERROR);
                return View(searchViewModel);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                SearchViewModel searchViewModel = new SearchViewModel();
                this.AddNotification("Please enter a valid value", NotificationType.ERROR);
                return View(searchViewModel);
            }

        }

        // GET: Whiskey/Details/5
        [Authorize]
        public ActionResult WhiskeyData(string id)
        {
            return View(_dataService.GetWhiskey(id));
        }

        // GET: Whiskey/Create
        [Authorize]
        public ActionResult AddNewWhiskey()
        {
            return View();
        }

        // POST: Whiskey/Create
        [Authorize]
        [HttpPost]
        public ActionResult AddNewWhiskey(WhiskeyModel whiskey, HttpPostedFileBase StoredImage, string submit)
        {
            
            try
            {
                if (submit == "Create")
                {

                    whiskey.LabelImage = StoredImage;
                    // TODO: Add insert logic here
                    _dataService.AddWhiskey(whiskey);
                    return RedirectToAction("WhiskeyOverView");
                }
                else if (submit == "CreateAnotherOne")
                {
                    whiskey.LabelImage = StoredImage;
                    // TODO: Add insert logic here
                    _dataService.AddWhiskey(whiskey);
                    return RedirectToAction("AddNewWhiskey");

                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Whiskey/Edit/5
        [Authorize]
        public ActionResult ChangeWhiskeyData(string id)
        {
            return View(_dataService.GetWhiskey(id));
        }

        // POST: Whiskey/Edit/5
        [Authorize]
        [HttpPost]
        public ActionResult ChangeWhiskeyData(string id, WhiskeyModel whiskey, HttpPostedFileBase StoredImage)
        {
            try
            {
                // TODO: Add update logic here
                whiskey.LabelImage = StoredImage;
                _dataService.UpdateWhiskey(whiskey);
                return RedirectToAction("WhiskeyOverView");
            }
            catch
            {
                return View();
            }
        }
    }
}
