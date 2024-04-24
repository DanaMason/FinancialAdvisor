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
        private RiskTolerance.RiskToleranceData _riskData;
        private Database _database;

        public RiskyInvestments(RiskTolerance.RiskToleranceData riskData, Database database)
        {
            this._riskData = riskData;
            this._database = database;
            _riskierInvestmentsPercent = CalculateInvestmentPercent(50);
        }
        private double CalculateInvestmentPercent(double initialValue)
        {
            var adjustments = _database.GetCategoryAdjustments("RiskyInvestments");
            double temp = initialValue;

            temp += adjustments[_riskData.Goal];
            temp += adjustments[_riskData.Timeline];
            temp += adjustments[_riskData.IntendedRisk];
            temp += adjustments[_riskData.SpendingHabits];
            temp += adjustments[_riskData.Cashflow];

            return Math.Max(0, Math.Min(100, temp));
        }

        public override double getRiskierInvestmentsPercent()
        {
            return _riskierInvestmentsPercent;
        }
    }
}
