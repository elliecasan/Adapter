using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Lib
{
    public class Product: IProduct
    {
       
        public decimal UnitPrice 
        { get { return 2233; }}
        public string BarCode 
        { get { return "####"; }  }
        public string Title 
        { get { return "Product"; } }

      
    }
}
