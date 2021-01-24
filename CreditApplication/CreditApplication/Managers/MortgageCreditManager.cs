using System;
using System.Collections.Generic;
using System.Text;

namespace CreditApplication
{
    //Mortgage = (creditAmount % 5) + 1
    class MortgageCreditManager : ICreditManager
    {
        public string Calculate(int creditAmount)
        {
            return (creditAmount % 5) + 1 + " - month mortagage loan was calculated.";
        }
    }
}
