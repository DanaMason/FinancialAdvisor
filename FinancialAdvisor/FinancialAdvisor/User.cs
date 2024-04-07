using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAdvisor
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
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public void getRisk()
		{
			throw new NotImplementedException();
		}

		public double getCash()
		{
			throw new NotImplementedException();
		}

		public void setCash(double current_cash)
		{
			throw new NotImplementedException();
		}

		public User()
		{
			MessageBox.Show("Hello!");
        }
	}
}
