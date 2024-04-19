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
using static FinancialAdvisor.RiskTolerance;

namespace FinancialAid
{
    //MessageBox.Show($"Name: {user.Name}, Total Cash: {user.getCash()}", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

    public partial class FinancialAdvisor : Form
    {
        private User user;
        RiskTolerance riskTolerance = new RiskTolerance();
        public FinancialAdvisor(User user)
        {
            InitializeComponent();
            this.user = user;
            WelcomeBox.Text = "Welcome " + user.Name + ", welcome to FinancialAid.io! Please follow the instructions that follow.";
        }

        private void RiskQuizButton_Click(object sender, EventArgs e)
        {
            RiskQuizForm riskQuizForm = new RiskQuizForm(riskTolerance, this);
            riskQuizForm.Show();
        }

        private void button1_Click(object sender, EventArgs e) // Calc button
        {
            double cashToInvest = user.getCash(); 
            PortfolioForm portfolioForm = new PortfolioForm(cashToInvest);
            portfolioForm.Show();
        }

        private void QuizTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void WelcomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinancialAdivsor_Load(object sender, EventArgs e)
        {

        }
        public void recieveandanalyzeRisk(RiskTolerance.RiskToleranceData info)
        {
            //= info;
            MessageBox.Show($"Goal: {info.Goal}\nTimeline: {info.Timeline}\nIntended Risk: {info.IntendedRisk}\nIncome: {info.Income}\nSpending Habits: {info.SpendingHabits}\nCashflow: {info.Cashflow}\nReal Estate: {info.RealEstate}", "Risk Tolerance Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
