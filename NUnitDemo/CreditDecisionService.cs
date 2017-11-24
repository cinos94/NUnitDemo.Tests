using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo
{
    class CreditDecisionService : ICreditDecisionService
    {
        public string GetCreditDecision(int creditScore)
        {
            if (creditScore < 550)
                return "Declined";
            else if (creditScore <= 675)
                return "Maybe";
            else
                return "We look forward to doing business with you!";
        }
    }
}
