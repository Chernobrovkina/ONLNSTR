using BeautySPA.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BeautySPA.Data.Interfaces
{
    public interface IAllWatches
    {
        IEnumerable <Watch> watches { get; }
        IEnumerable <Watch> GetFavWatches { get;}
        Watch GetObWatch  (int Watchid);
    }
}
