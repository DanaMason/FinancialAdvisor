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
    public partial class PortfolioForm : Form
    {
        private Portfolio portfolio;  
        private double cashToInvest;
        public PortfolioForm(double cashToInvest)
        {
            InitializeComponent();

            this.cashToInvest = cashToInvest;

            portfolio = new Portfolio();

            StablePercent.Text = portfolio.getStableInvestmentPercent().ToString("F2") + "%";
            RiskyPercent.Text = portfolio.getRiskierInvestmentsPercent().ToString("F2") + "%";
            StockPercent.Text = portfolio.getStockPercent().ToString("F2") + "%";
            REPercent.Text = portfolio.getRealEstatePercent().ToString("F2") + "%";
            ETFPercent.Text = portfolio.getETFPercent().ToString("F2") + "%";
            TotalPercent.Text = ("100.00%");

            MoneyStable.Text = "$ " + (cashToInvest * (portfolio.getStableInvestmentPercent() / 100)).ToString("F2");
            MoneyRisky.Text = "$ " + (cashToInvest * (portfolio.getRiskierInvestmentsPercent() / 100)).ToString("F2");
            MoneyStocks.Text = "$ " + (cashToInvest * (portfolio.getStockPercent() / 100)).ToString("F2");
            MoneyRE.Text = "$ " + (cashToInvest * (portfolio.getRealEstatePercent() / 100)).ToString("F2");
            MoneyEtf.Text = "$ " + (cashToInvest * (portfolio.getETFPercent() / 100)).ToString("F2");
            totalCash.Text = "$ " + (cashToInvest).ToString("F2");
        }
        private void PortfolioForm_Load(object sender, EventArgs e)
        {
               
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoneyRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoneyStocks_TextChanged(object sender, EventArgs e)
        {

        }

        private void REPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void StockPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void RiskyPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoneyRisky_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoneyStable_TextChanged(object sender, EventArgs e)
        {

        }

        private void StablePercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
