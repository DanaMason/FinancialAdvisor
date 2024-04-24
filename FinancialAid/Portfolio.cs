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
    public abstract class Portfolio : User       // Gives several virtual methods to later override.
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

        public abstract double getRealEstatePercent();

        public Portfolio()
        {
             
        }
    }
}
