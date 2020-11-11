using BeautySPA.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ONLNSTR.Data.Models;
using ONLNSTR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONLNSTR.Controllers
{
    public class ShopWatchController : Controller {
    
        private IAllWatches _watchRep;
        private readonly ShopWatch _shopWatch;

        public ShopWatchController(IAllWatches watchRep, ShopWatch shopWatch)
        {
            _watchRep = watchRep;
            _shopWatch = shopWatch;
        }

        public ViewResult Index()
        {
            var items = _shopWatch.getShopItems();
            _shopWatch.listShopItems = items;

            var obj = new ShopWatchViewModel
            {
                ShopWatch = _shopWatch
            };
            return View(obj);
        }

        public RedirectToActionResult addToWatch(int id)
        {
            var item = _watchRep.watches.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopWatch.AddToWatch(item);
            }
            return RedirectToAction("Index");
        }
    }
}
