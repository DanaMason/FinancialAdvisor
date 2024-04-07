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
    public partial class UserForm : Form
    {
        private User user;
        public UserForm(User newUser)
        {
            InitializeComponent();
            user = newUser;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinancialAdivsor advisorForm = new FinancialAdivsor();
            advisorForm.ShowDialog();
            this.Close();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            user.Name = nameTextBox.Text;
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(cashTextBox.Text, out double cash))
            {
                user.setCash(cash);
            }
            else
            {
                MessageBox.Show("Please enter a valid CASH amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}