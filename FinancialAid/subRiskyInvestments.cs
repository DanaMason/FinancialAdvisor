using FinancialAdvisor;
using FinancialAid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAid
{
    public class subRiskyInvestments : Portfolio
    {
        private double _stocksPercent;
        private double _realEstatePercent;
        private double _etfPercent;
        private RiskTolerance.RiskToleranceData riskData;
        private Database database;

        public subRiskyInvestments(RiskTolerance.RiskToleranceData riskData, Database database)
        {
            this.riskData = riskData;
            this.database = database;
            callCalc();
        }

        public void callCalc()
        {
            if (riskData.RealEstate == "No")
            {
                _stocksPercent = CalculateInvestmentPercent(25, "Stocks");
                _etfPercent = CalculateInvestmentPercent(25, "ETFs");     
                _realEstatePercent = 0;                                   
            }
            else if (riskData.RealEstate == "Yes")
            {
                _stocksPercent = CalculateInvestmentPercent(20, "Stocks"); 
                _etfPercent = CalculateInvestmentPercent(20, "ETFs");     
                _realEstatePercent = CalculateInvestmentPercent(10, "Real Estate"); 
            }
        }

        public override double getStockPercent()
        {
            return _stocksPercent;
        }

        public override double getETFPercent()
        {
            return _etfPercent;
        }

        public override double getRealEstatePercent()
        {
            return _realEstatePercent;
        }

        private double CalculateInvestmentPercent(double initialValue, string category)
        {
            var adjustments = database.GetCategoryAdjustments(category);
            double temp = initialValue;

            temp += adjustments[riskData.Goal];
            temp += adjustments[riskData.Timeline];
            temp += adjustments[riskData.IntendedRisk];
            temp += adjustments[riskData.SpendingHabits];
            temp += adjustments[riskData.Cashflow];

            return Math.Max(0, Math.Min(100, temp));
        }
    }
}
