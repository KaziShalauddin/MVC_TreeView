using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Treeview.Models
{
    public class AppDB_Context : DbContext
    {
        public AppDB_Context() : base("name=DefaultConnection") { }

        public DbSet<Location> Locations { get; set; }

    }
}