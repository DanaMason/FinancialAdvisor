using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAid
{
    public class User
    {
        private string _name;
        private double _riskTolerance;
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

        public double getRisk()
        {
            return _riskTolerance;
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
