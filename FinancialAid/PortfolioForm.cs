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
        private StableInvestments stableInvestments;
        private RiskyInvestments riskyInvestments;
        private subRiskyInvestments subRiskyInvestments;
        private double cashToInvest;
        private RiskTolerance.RiskToleranceData riskData;
        private Database database;


        public PortfolioForm(double cashToInvest, RiskTolerance.RiskToleranceData riskData)
        {
            InitializeComponent();

            this.cashToInvest = cashToInvest;
            this.riskData = riskData;
            this.database = new Database(riskData.RealEstate);

            stableInvestments = new StableInvestments(riskData, database);
            riskyInvestments = new RiskyInvestments(riskData, database);
            subRiskyInvestments = new subRiskyInvestments(riskData, database);
        }
        private void PortfolioForm_Load(object sender, EventArgs e)
        {
            StablePercent.Text = stableInvestments.getStableInvestmentPercent().ToString("F2") + "%";
            RiskyPercent.Text = riskyInvestments.getRiskierInvestmentsPercent().ToString("F2") + "%";
            StockPercent.Text = subRiskyInvestments.getStockPercent().ToString("F2") + "%";
            REPercent.Text = subRiskyInvestments.getRealEstatePercent().ToString("F2") + "%";
            ETFPercent.Text = subRiskyInvestments.getETFPercent().ToString("F2") + "%";
            TotalPercent.Text = "100.00%";

            MoneyStable.Text = "$ " + (cashToInvest * (stableInvestments.getStableInvestmentPercent() / 100)).ToString("F2");
            MoneyRisky.Text = "$ " + (cashToInvest * (riskyInvestments.getRiskierInvestmentsPercent() / 100)).ToString("F2");
            MoneyStocks.Text = "$ " + (cashToInvest * (subRiskyInvestments.getStockPercent() / 100)).ToString("F2");
            MoneyRE.Text = "$ " + (cashToInvest * (subRiskyInvestments.getRealEstatePercent() / 100)).ToString("F2");
            MoneyEtf.Text = "$ " + (cashToInvest * (subRiskyInvestments.getETFPercent() / 100)).ToString("F2");
            totalCash.Text = "$ " + cashToInvest.ToString("F2");
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
