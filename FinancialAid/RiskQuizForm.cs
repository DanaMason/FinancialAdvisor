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
            int truth = 0;

            if (GoalsDB.Text == "- Select -" || TimelineDB.Text == "- Select -" || RiskDB.Text == "- Select -" || IncomeDB.Text == "- Select -" || SpendingHabitsDB.Text == "- Select -" || CashflowDB.Text == "- Select -" || RealEstateDB.Text == "- Select -")
            {
                MessageBox.Show("Please select an answer for all questions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                truth = 1;
            }

            if (truth == 0)
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
        
        }

        private void GoalsDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RealEstateDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TitleRisktxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CashflowDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SpendingHabitsDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IncomeDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RiskDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimelineDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

