﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Lib
{
    public class Product: IProduct
    {
        public decimal UnitPrice { get; set; }
        public string BarCode { get; set; }
        public string Title { get; set; }
    }
}
