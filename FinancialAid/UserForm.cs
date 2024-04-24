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
        bool nameT, cashT = false;
        public UserForm(User newUser)
        {
            InitializeComponent();
            user = newUser;             // creates a new user.
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            // Logic for determining if the information is valid and then continues on to the Financial Advisor Form.

            if (nameT == false)
            {
                MessageBox.Show("Please enter a name.", "Invalid Name Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cashT == false)
            {
                MessageBox.Show("Please enter a valid cash amount.", "Invalid Cash Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            FinancialAdvisor advisorForm = new FinancialAdvisor(user);
            advisorForm.ShowDialog();
            this.Close();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            // Ensures name is legit. Also saves name.

            if (nameTextBox.Text != "")
            {
                user.Name = nameTextBox.Text;
                nameT = true;
                return;
            }
            else if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameT = false;
                return;
            }

        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            // Ensures cash entered was valid. Also saves cash amount.

            if (double.TryParse(cashTextBox.Text, out double cash))
            {
                user.Cash = cash;
                cashT = true;
                return;
            }
            else
            {
                MessageBox.Show("Please enter a valid cash amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cashT = false;
                return;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cashTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void WelcomeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}