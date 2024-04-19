using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAdvisor
{
	public class Portfolio : User
	{
		private double _stableInvestmentPercent;
		private double _RiskierInvestmentsPercent;
		private double _stocksPercent;
		private double _realEstatePercent;
		private double _etfPercent;

		public double getStableInvestmentPercent()
		{
			return _stableInvestmentPercent;

        }

		public double getRiskierInvestmentsPercent()
		{
			return _RiskierInvestmentsPercent;

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
			throw new NotImplementedException();
		}
	}
}
