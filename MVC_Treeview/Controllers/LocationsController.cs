
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVC_Treeview.Models;
using MVC_Treeview.ViewModels;

namespace MVC_Treeview.Controllers
{
    public class LocationsController : Controller
    {
        public JsonResult Get(string query)
        {
            List<Location> locations;
            List<LocationVm> records;
            using (AppDB_Context context = new AppDB_Context())
            {
                locations = context.Locations.ToList();

                if (!string.IsNullOrWhiteSpace(query))
                {
                    locations = locations.Where(q => q.Name.Contains(query)).ToList();
                }

                records = locations.Where(l => l.ParentID == null).OrderBy(l => l.OrderNumber)
                    .Select(l => new LocationVm
                    {
                        id = l.ID,
                        text = l.Name,
                        @checked = l.Checked,
                        //population = l.Population,
                        //flagUrl = l.FlagUrl,
                        children = GetChildren(locations, l.ID)
                    }).ToList();
            }

            return this.Json(records, JsonRequestBehavior.AllowGet);
        }

       

        private List<LocationVm> GetChildren(List<Location> locations, int parentId)
        {
            return locations.Where(l => l.ParentID == parentId).OrderBy(l => l.OrderNumber)
                .Select(l => new LocationVm
                {
                    id = l.ID,
                    text = l.Name,
                   // population = l.Population,
                    //flagUrl = l.FlagUrl,
                    @checked = l.Checked,
                    children = GetChildren(locations, l.ID)
                }).ToList();
        }

        [HttpPost]
        public JsonResult SaveCheckedNodes(List<int> checkedIds)
        {
            if (checkedIds == null)
            {
                checkedIds = new List<int>();
            }
            using (AppDB_Context context = new AppDB_Context())
            {
                var locations = context.Locations.ToList();
                foreach (var location in locations)
                {
                    location.Checked = checkedIds.Contains(location.ID);
                }
                context.SaveChanges();
            }

            return this.Json(true);
        }

        //[HttpPost]
        //public JsonResult ChangeNodePosition(int id, int parentId, int orderNumber)
        //{
        //    using (AppDB_Context context = new AppDB_Context())
        //    {
        //        var location = context.Locations.First(l => l.ID == id);

        //        var newSiblingsBelow = context.Locations.Where(l => l.ParentID == parentId && l.OrderNumber >= orderNumber);
        //        foreach (var sibling in newSiblingsBelow)
        //        {
        //            sibling.OrderNumber = sibling.OrderNumber + 1;
        //        }

        //        var oldSiblingsBelow = context.Locations.Where(l => l.ParentID == location.ParentID && l.OrderNumber > location.OrderNumber);
        //        foreach (var sibling in oldSiblingsBelow)
        //        {
        //            sibling.OrderNumber = sibling.OrderNumber - 1;
        //        }


        //        location.ParentID = parentId;
        //        location.OrderNumber = orderNumber;

        //        context.SaveChanges();
        //    }

        //    return this.Json(true);
        //}

        //public JsonResult GetCountries(string query)
        //{
        //    List<LocationVm> records;
        //    using (AppDB_Context context = new AppDB_Context())
        //    {
        //        records = context.Locations.Where(l => l.Parent != null && l.Parent.ParentID == null)
        //            .Select(l => new LocationVm
        //            {
        //                id = l.ID,
        //                text = l.Name,
        //                @checked = l.Checked,
        //                population = l.Population,
        //                flagUrl = l.FlagUrl
        //            }).ToList();
        //    }

        //    return this.Json(records, JsonRequestBehavior.AllowGet);
        //}
    }
}