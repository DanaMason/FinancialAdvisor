using FinancialAid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAid
{
    public class Portfolio : User
    {
        private double _stableInvestmentPercent;
        private double _riskierInvestmentsPercent;
        private double _stocksPercent;
        private double _realEstatePercent;
        private double _etfPercent;

        public double getStableInvestmentPercent()
        {
            return _stableInvestmentPercent;
        }

        public double getRiskierInvestmentsPercent()
        {
            return _riskierInvestmentsPercent;
        }

        public double getStockPercent()
        {
            return _stocksPercent;
        }

        public double getETFPercent()
        {
            return _realEstatePercent;
        }

        public double getRealEstatePercent()
        {
            return _etfPercent;
        }

        public Portfolio()
        {
            _stableInvestmentPercent = 79.468;
            _riskierInvestmentsPercent = 20.532;
            _stocksPercent = 1.0;
            _realEstatePercent = 1.0;
            _etfPercent = 18.532;
        }
    }
}
