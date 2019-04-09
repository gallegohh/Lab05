using System;
using System.Collections.Generic;

namespace Lab05.DB
{
    public partial class Territories
    {
        public Territories()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritories>();
        }

        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }

        public Region Region { get; set; }
        public ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
    }
}
