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
