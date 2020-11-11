using BeautySPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautySPA.Data.Interfaces
{
    public 
        interface IWatchesCatecory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
