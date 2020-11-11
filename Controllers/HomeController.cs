using BeautySPA.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ONLNSTR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONLNSTR.Controllers
{
    public class HomeController: Controller
    {
        private IAllWatches _watchRep;

        public HomeController(IAllWatches watchRep)
        {
            _watchRep = watchRep;
        }
        public ViewResult Index()
        {
            var homeWatch = new HomeViewModel
            {
                favwatch = _watchRep.GetFavWatches
            };
            return View(homeWatch);
        }
    }
}
