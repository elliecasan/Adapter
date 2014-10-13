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
        private readonly SomeExternalVendorProduct someProduct;

        public SomeExtrernalVendorProductAdapter(SomeExternalVendorProduct someProduct)
        {
            this.someProduct = someProduct;
        }
        public decimal UnitPrice { get { return someProduct.PricePerUnit; }}
        public string BarCode { get { return someProduct.EANCode; }}
        public string Title { get { return someProduct.Description; }}
    }
}
