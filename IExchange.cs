using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface4
{
    internal interface IExchange
    {
        double Rate { get; }
        void Convert();
    }
}
