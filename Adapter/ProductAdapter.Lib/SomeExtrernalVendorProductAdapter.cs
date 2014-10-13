using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Lib;


namespace ProductAdapter.Lib
{
    public class SomeExtrernalVendorProductAdapter : IProduct
    {
        private SomeExternalVendorProduct someProduct;
        public SomeExtrernalVendorProductAdapter(SomeExternalVendorProduct someProduct)
        {
            someProduct = someProduct;
        }
        public decimal UnitPrice { get; set; }
        public string BarCode { get; set; }
        public string Title { get; set; }
    }
}
