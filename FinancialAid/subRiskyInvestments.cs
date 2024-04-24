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
        private RiskTolerance.RiskToleranceData _riskData;
        private Database _database;

        public subRiskyInvestments(RiskTolerance.RiskToleranceData riskData, Database database)
        {
            this._riskData = riskData;
            this._database = database;
            callCalc();
        }

        public void callCalc()  // Determines how to calculate everything, and calls the calc method.
        {
            if (_riskData.RealEstate == "No")
            {
                _stocksPercent = CalculateInvestmentPercent(25, "Stocks");
                _etfPercent = CalculateInvestmentPercent(25, "ETFs");     
                _realEstatePercent = 0;                                   
            }
            else if (_riskData.RealEstate == "Yes")
            {
                _stocksPercent = CalculateInvestmentPercent(20, "Stocks"); 
                _etfPercent = CalculateInvestmentPercent(20, "ETFs");     
                _realEstatePercent = CalculateInvestmentPercent(10, "Real Estate"); 
            }
        }

        // The following three methods override the virtual methods in Portfolio.

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

        private double CalculateInvestmentPercent(double initialValue, string category) // Calcs the percentages for each thing passed in.
        {
            var adjustments = _database.GetCategoryAdjustments(category);
            double temp = initialValue;

            temp += adjustments[_riskData.Goal];
            temp += adjustments[_riskData.Timeline];
            temp += adjustments[_riskData.IntendedRisk];
            temp += adjustments[_riskData.SpendingHabits];
            temp += adjustments[_riskData.Cashflow];

            return Math.Max(0, Math.Min(100, temp));
        }
    }
}
