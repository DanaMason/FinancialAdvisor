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

        public string Name      // For the name var.
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

        public double Cash      // For the cash to invest
        {
            get
            {
                return _cashToInvest;
            }
            set
            {
                _cashToInvest = value;
            }
        }

        public User()
        {
            
        }
    }
}
