using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pon2._0.DataModels
{
    public class LinkEntity : DbContext
    {
        public DbSet<LinkDataModel> Links { get; set; }
        public DbSet<MiniLinkDataModel> MiniLinks { get; set; }
    }
}