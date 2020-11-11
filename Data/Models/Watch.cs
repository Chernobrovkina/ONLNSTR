using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautySPA.Data.Models
{
    public class Watch
    {
        public int id { set; get; }
        public string name { set; get; }
        public string parameter { set; get; }
        public string description { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool favourites { set; get; }
        public bool available { set; get; }
        public int categoryid { set; get; }
        public virtual Category Category { set; get; }


    }
}
