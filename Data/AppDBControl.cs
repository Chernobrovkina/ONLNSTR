using BeautySPA.Data.Models;
using Microsoft.EntityFrameworkCore;
using ONLNSTR.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONLNSTR.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        { }
            public DbSet<Watch> Watch { get; set; }
            public DbSet <Category> Category { get; set; }
            public DbSet<ShopWatchItem> ShopWatchItem { get; set; }
    }
    }


