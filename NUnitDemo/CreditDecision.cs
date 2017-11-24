using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo
{
    public class CreditDecision
    {
        ICreditDecisionService creditDecisionService;
        public CreditDecision(ICreditDecisionService creditDecisionService)
        {
            this.creditDecisionService = creditDecisionService;
        }

        public string MakeCreditDecision(int creditScore)
        {
            return creditDecisionService.GetCreditDecision(creditScore);
        }
    }
}
