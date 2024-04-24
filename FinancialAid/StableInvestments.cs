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
    public class StableInvestments : Portfolio
    {
        private double _stableInvestmentPercent;
        private RiskTolerance.RiskToleranceData _riskData;
        private Database _database;

        public StableInvestments(RiskTolerance.RiskToleranceData riskData, Database database)
        {
            this._riskData = riskData;
            this._database = database;
            _stableInvestmentPercent = CalculateInvestmentPercent(50);
        }

        private double CalculateInvestmentPercent(double initialValue)
        {
           var adjustments = _database.GetCategoryAdjustments("StableInvestments");
            double temp = initialValue;

            temp += adjustments[_riskData.Goal];
            temp += adjustments[_riskData.Timeline];
            temp += adjustments[_riskData.IntendedRisk];
            temp += adjustments[_riskData.SpendingHabits];
            temp += adjustments[_riskData.Cashflow];

            return Math.Max(0, Math.Min(100, temp));
        }

        public override double getStableInvestmentPercent()
        {
            return _stableInvestmentPercent;
        }
    }
}
