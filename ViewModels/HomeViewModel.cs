using BeautySPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONLNSTR.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Watch> favwatch { get; set; }
    }
}
