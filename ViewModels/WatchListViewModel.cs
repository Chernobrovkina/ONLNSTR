using BeautySPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONLNSTR.ViewModels
{
    public class WatchListViewModel
    {


        public IEnumerable<Watch> allWatch { get; set; }
        public string currCategory { get; set; }

    }
}
