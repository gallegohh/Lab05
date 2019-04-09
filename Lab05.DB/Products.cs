﻿using System;
using System.Collections.Generic;

namespace Lab05.DB
{
    public partial class Products
    {
        public Products()
        {
            Order_Details = new HashSet<Order_Details>();
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public Categories Category { get; set; }
        public Suppliers Supplier { get; set; }
        public ICollection<Order_Details> Order_Details { get; set; }
    }
}
