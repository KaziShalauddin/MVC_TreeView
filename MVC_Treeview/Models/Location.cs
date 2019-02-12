using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Treeview.Models
{
    public class Location
    {
        public int ID { get; set; }
        //level
        public int? ParentID { get; set; }
        //menu
        public string Name { get; set; }
        //status
        public bool Checked { get; set; }
        //order
        public int OrderNumber { get; set; }

        //Population--Not needed for Treeview
        public long? Population { get; set; }
        //url--Not needed for Treeview
        public string FlagUrl { get; set; }
        
        public virtual Location Parent { get; set; }

        public virtual List<Location> Children { get; set; }
    }
}
