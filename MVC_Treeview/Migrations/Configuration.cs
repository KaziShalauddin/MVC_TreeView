using MVC_Treeview.Models;

namespace MVC_Treeview.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDB_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        //protected override void Seed(AppDB_Context context)
        //{
        //    //  This method will be called after migrating to the latest version.

        //    //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //    //  to avoid creating duplicate seed data.
        //}

        protected override void Seed(AppDB_Context context)
        {
            context.Locations.AddOrUpdate(
                new Location { ID = 1, ParentID = null, Name = "Asia", OrderNumber = 1, Population = null },
                new Location { ID = 2, ParentID = 1, Name = "China", OrderNumber = 1, Population = 1373541278, FlagUrl = "http://code.gijgo.com/flags/24/China.png" },
                new Location { ID = 3, ParentID = 1, Name = "Japan", OrderNumber = 2, Population = 126730000, FlagUrl = "http://code.gijgo.com/flags/24/Japan.png" },
                new Location { ID = 4, ParentID = 1, Name = "Mongolia", OrderNumber = 3, Population = 3081677, FlagUrl = "http://code.gijgo.com/flags/24/Mongolia.png" },
                new Location { ID = 5, ParentID = null, Name = "North America", OrderNumber = 2, Population = null },
                new Location { ID = 6, ParentID = 5, Name = "USA", OrderNumber = 1, Population = 325145963, FlagUrl = "http://code.gijgo.com/flags/24/United%20States%20of%20America(USA).png" },
                new Location { ID = 7, ParentID = 6, Name = "California", OrderNumber = 1, Population = 39144818 },
                new Location { ID = 8, ParentID = 6, Name = "Florida", OrderNumber = 2, Population = 20271272 },
                new Location { ID = 9, ParentID = 5, Name = "Canada", OrderNumber = 2, Population = 35151728, FlagUrl = "http://code.gijgo.com/flags/24/canada.png" },
                new Location { ID = 10, ParentID = 5, Name = "Mexico", OrderNumber = 3, Population = 119530753, FlagUrl = "http://code.gijgo.com/flags/24/mexico.png" },
                new Location { ID = 11, ParentID = null, Name = "South America", OrderNumber = 3, Population = null },
                new Location { ID = 12, ParentID = 11, Name = "Brazil", OrderNumber = 1, Population = 207350000, FlagUrl = "http://code.gijgo.com/flags/24/brazil.png" },
                new Location { ID = 13, ParentID = 11, Name = "Argentina", OrderNumber = 2, Population = 43417000, FlagUrl = "http://code.gijgo.com/flags/24/argentina.png" },
                new Location { ID = 14, ParentID = 11, Name = "Colombia", OrderNumber = 3, Population = 49819638, FlagUrl = "http://code.gijgo.com/flags/24/colombia.png" },
                new Location { ID = 15, ParentID = null, Name = "Europe", OrderNumber = 4, Population = null },
                new Location { ID = 16, ParentID = 15, Name = "England", OrderNumber = 1, Population = 54786300, FlagUrl = "http://code.gijgo.com/flags/24/england.png" },
                new Location { ID = 17, ParentID = 15, Name = "Germany", OrderNumber = 2, Population = 82175700, FlagUrl = "http://code.gijgo.com/flags/24/germany.png" },
                new Location { ID = 18, ParentID = 15, Name = "Bulgaria", OrderNumber = 3, Population = 7101859, FlagUrl = "http://code.gijgo.com/flags/24/bulgaria.png" },
                new Location { ID = 19, ParentID = 15, Name = "Poland", OrderNumber = 4, Population = 38454576, FlagUrl = "http://code.gijgo.com/flags/24/poland.png" }
            );

           
        }
    }
}
