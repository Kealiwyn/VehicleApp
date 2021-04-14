using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    interface ISellable
    {
        double CalculateInterest();
        string MakeSale();
    }
}
