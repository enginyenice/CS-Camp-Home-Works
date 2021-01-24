using System;
using System.Collections.Generic;
using System.Text;

namespace CreditApplication
{
    interface ICreditManager
    {
        public string Calculate(int creditAmount);
    }
}
