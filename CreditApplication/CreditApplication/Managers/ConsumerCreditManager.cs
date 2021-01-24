using System;
using System.Collections.Generic;
using System.Text;

namespace CreditApplication
{

    //Consumer = (creditAmount % 24) + 1
    class ConsumerCreditManager :ICreditManager
    {
        public string Calculate(int creditAmount)
        {

            return (creditAmount % 24) + 1 + " - month consumer loan was calculated.";
        }
    }
}
