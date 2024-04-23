using FinancialAdvisor;
using FinancialAid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAid
{
    public class RiskyInvestments : Portfolio
    {
        private double _riskierInvestmentsPercent;
        private RiskTolerance.RiskToleranceData riskData;
        private Database database;

        public RiskyInvestments(RiskTolerance.RiskToleranceData riskData, Database database)
        {
            this.riskData = riskData;
            this.database = database;
            _riskierInvestmentsPercent = CalculateInvestmentPercent(50);
        }
        private double CalculateInvestmentPercent(double initialValue)
        {
            var adjustments = database.GetCategoryAdjustments("RiskyInvestments");
            double temp = initialValue;

            temp += adjustments[riskData.Goal];
            temp += adjustments[riskData.Timeline];
            temp += adjustments[riskData.IntendedRisk];
            temp += adjustments[riskData.SpendingHabits];
            temp += adjustments[riskData.Cashflow];

            return Math.Max(0, Math.Min(100, temp));
        }

        public override double getRiskierInvestmentsPercent()
        {
            return _riskierInvestmentsPercent;
        }
    }
}
