using BeautySPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONLNSTR.Data.Models
{
    public class ShopWatchItem
    {
        public int id { get; set; }
        public Watch watch { get; set; }
        public int price { get; set; }
        public string ShopWatchId { get; set; }

    }
}
