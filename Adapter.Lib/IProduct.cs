using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Lib
{
    public interface IProduct
    {
        decimal UnitPrice { get;  }
        string BarCode { get;}
        string Title { get; }
    }
}
