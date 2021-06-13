﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerProductWebApplication.ViewModel
{
    public class StockViewModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int ShopNo { get; set; }
        public string ProductName { get; set; }
    }
}
