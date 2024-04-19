using FinancialAdvisor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAid
{
    public partial class RiskQuizForm : Form
    {



        private FinancialAdvisor financialAdvisor;
        private RiskTolerance riskTolerance;
        public RiskQuizForm(RiskTolerance newRiskTolerance, FinancialAdvisor advisor)
        {
            InitializeComponent();
            this.riskTolerance = newRiskTolerance;
            this.financialAdvisor = advisor;
        }

        private void RiskQuizForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveContinueBtn_Click(object sender, EventArgs e)
        {
            RiskTolerance.RiskToleranceData info = new RiskTolerance.RiskToleranceData
            {
                Goal = GoalsDB.Text,
                Timeline = TimelineDB.Text,
                IntendedRisk = RiskDB.Text,
                Income = IncomeDB.Text,
                SpendingHabits = SpendingHabitsDB.Text,
                Cashflow = CashflowDB.Text,
                RealEstate = RealEstateDB.Text
            };

            this.Close();

            financialAdvisor.recieveandanalyzeRisk(info);
        
        }

        private void GoalsDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

