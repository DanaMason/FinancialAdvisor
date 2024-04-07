using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAdvisor
{
    public partial class FinancialAid : Form
    {
        public FinancialAid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RiskQuizButton_Click(object sender, EventArgs e)
        {
            var riskQuiz = new RiskQuiz();
            riskQuiz.Show();
        }
    }
}
