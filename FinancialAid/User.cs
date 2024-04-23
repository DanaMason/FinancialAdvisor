using FinancialAdvisor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinancialAdvisor.RiskTolerance;

namespace FinancialAid
{
    public class User
    {
        private string _name;
        private double _cashToInvest;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /*public string getRisk()
        {
            MessageBox.Show($"Goal: {_riskTolerance.Goal}\nTimeline: {_riskTolerance.Timeline}\nIntended Risk: {_riskTolerance.IntendedRisk}\nIncome: {_riskTolerance.Income}\nSpending Habits: {_riskTolerance.SpendingHabits}\nCashflow: {_riskTolerance.Cashflow}\nReal Estate: {_riskTolerance.RealEstate}", "Risk Tolerance Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }*/

        public double getCash()
        {
            return _cashToInvest;
        }

        public void setCash(double current_cash)
        {
            _cashToInvest = current_cash;
        }

        public User()
        {
            
        }
    }
}
