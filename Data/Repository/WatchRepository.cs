
using BeautySPA.Data.Interfaces;
using BeautySPA.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONLNSTR.Data.Repository
{
    public class WatchRepository : IAllWatches
    {
        private readonly AppDBContent appDBContent;
        public WatchRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Watch> watches => appDBContent.Watch.Include(c => c.Category );

        public IEnumerable<Watch> GetFavWatches => appDBContent.Watch.Where(p => p.favourites).Include(c => c.Category);

        public Watch GetObWatch(int Watchid) => appDBContent.Watch.FirstOrDefault(p => p.id == Watchid);
    }
}
