using FinancialAdvisor;
using FinancialAid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAid
{
    public class Portfolio : User
    {

        public virtual double getStableInvestmentPercent()
        {
            return 50.0;
        }

        public virtual double getRiskierInvestmentsPercent()
        {
            return 50.0;
        }

        public virtual double getStockPercent()
        {
            return 25.0;
        }

        public virtual double getETFPercent()
        {
            return 25.0;
        }

        public virtual double getRealEstatePercent()
        {
            return 0.0;
        }

        public Portfolio()
        {
             
        }
    }
}
