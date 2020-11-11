using BeautySPA.Data.Interfaces;
using BeautySPA.Data.Models;
using Microsoft.AspNetCore.Mvc;
using ONLNSTR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ONLNSTR.Controllers
{
    public class WatchController: Controller 
    {
        private readonly IAllWatches _allWatch;
        private readonly IWatchesCatecory _allCatecory;

        public WatchController(IAllWatches iallwatch, IWatchesCatecory iwatchescat)
        {
            _allWatch = iallwatch;
            _allCatecory = iwatchescat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Страница с часами";
            WatchListViewModel obj = new WatchListViewModel();
            obj.allWatch = _allWatch.watches;
            obj.currCategory = " Умные часы ";
            return View(obj);
        }
    }
}
