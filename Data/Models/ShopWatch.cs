using BeautySPA.Data.Models;
using ONLNSTR.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ONLNSTR.Data.Models
{
    public class ShopWatch
    {
        private readonly AppDBContent appDBContent;
        public ShopWatch(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopWatchId { get; set; }
        public List<ShopWatchItem> listShopItems { get; set; }

        public static ShopWatch GetShop(IServiceProvider service) {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBContent>();
            string shopWatchId = session.GetString("WatchId") ?? Guid.NewGuid().ToString();

            session.SetString("WatchId", shopWatchId);

            return new ShopWatch(context) { ShopWatchId = shopWatchId };
        }

        public void AddToWatch(Watch watch)
        {
            appDBContent.ShopWatchItem.Add(new ShopWatchItem
            {
                ShopWatchId = ShopWatchId,
                watch =watch,
                price = watch.price

            });
            appDBContent.SaveChanges();
        }
        public List<ShopWatchItem> getShopItems()
        {
            return appDBContent.ShopWatchItem.Where(c => c.ShopWatchId == ShopWatchId).Include(s => s.watch).ToList();
        }
    }    
}
