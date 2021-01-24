using System;
using System.Collections.Generic;
using System.Text;

namespace CreditApplication
{
    //Consumer = (creditAmount % 3) + 1
    class VehicleCreditManager : ICreditManager
    {
        public string Calculate(int creditAmount)
        {
            return (creditAmount % 3) + 1 + " - month vehicle loan was calculated.";
        }
    }
}
