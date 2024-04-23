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
        private bool riskQuizTaken = false;

        private RiskTolerance.RiskToleranceData _riskTolerance = new RiskTolerance.RiskToleranceData
        {
            Goal = null,
            Timeline = null,
            IntendedRisk = null,
            Income = null,
            SpendingHabits = null,
            Cashflow = null,
            RealEstate = null
        };

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (riskQuizTaken == false)
            {
                MessageBox.Show("Must take the Risk Quiz.", "No Risk Quiz Taken!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double cashToInvest = user.getCash(); 
            PortfolioForm portfolioForm = new PortfolioForm(cashToInvest, _riskTolerance);
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
            _riskTolerance.Goal = info.Goal;
            _riskTolerance.Timeline = info.Timeline;
            _riskTolerance.IntendedRisk = info.IntendedRisk;
            _riskTolerance.Income = info.Income;
            _riskTolerance.SpendingHabits = info.SpendingHabits;
            _riskTolerance.Cashflow = info.Cashflow;
            _riskTolerance.RealEstate = info.RealEstate;

            riskQuizTaken = true;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            this.Hide();

            User user = new User(); 
            UserForm userForm = new UserForm(user); 

            userForm.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
