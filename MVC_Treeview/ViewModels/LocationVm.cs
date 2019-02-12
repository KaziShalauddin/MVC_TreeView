using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Treeview.Models;

namespace MVC_Treeview.ViewModels
{
    public class LocationVm
    {
        public int id { get; set; }

        public string text { get; set; }

        public long? population { get; set; }

        public string flagUrl { get; set; }

        public bool @checked { get; set; }

        public bool hasChildren { get; set; }

        public virtual List<LocationVm> children { get; set; }
    }
}
