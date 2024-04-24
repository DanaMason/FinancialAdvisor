using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinancialAid;

namespace FinancialAidAutoTests
{
    [TestClass]
    public class FinancialAidTests
    {
        [TestMethod]
        public void TestNameTextBox_ValidInput()
        {
            UserForm userForm = new UserForm(new User());
            string expectedName = "John";
            userForm.nameTextBox.Text = expectedName;
            userForm.nameButton_Click(null, null);
            Assert.AreEqual(expectedName, userForm.user.Name);
            Assert.IsTrue(userForm.nameT);
        }

        [TestMethod]
        public void TestNameTextBox_EmptyInput()
        {
            UserForm userForm = new UserForm(new User());
            userForm.nameTextBox.Text = "";
            userForm.nameButton_Click(null, null);
            Assert.IsFalse(userForm.nameT);
        }

        [TestMethod]
        public void TestCashTextBox_ValidInput()
        {
            UserForm userForm = new UserForm(new User());
            double expectedCash = 1000.50;
            userForm.cashTextBox.Text = expectedCash.ToString();
            userForm.cashButton_Click(null, null);
            Assert.AreEqual(expectedCash, userForm.user.Cash);
            Assert.IsTrue(userForm.cashT);
        }

        [TestMethod]
        public void TestCashTextBox_InvalidInput()
        {
            UserForm userForm = new UserForm(new User());
            userForm.cashTextBox.Text = "not a number";
            userForm.cashButton_Click(null, null);
            Assert.IsFalse(userForm.cashT);
        }

        [TestMethod]
        public void TestContinueButton_NameNotEntered()
        {
            UserForm userForm = new UserForm(new User());
            userForm.continueButton_Click(null, null);
            Assert.IsFalse(userForm.IsDisposed);
        }

        [TestMethod]
        public void TestContinueButton_CashNotEntered()
        {
            UserForm userForm = new UserForm(new User());
            userForm.nameTextBox.Text = "John";
            userForm.continueButton_Click(null, null);
            Assert.IsFalse(userForm.IsDisposed);
        }

        [TestMethod]
        public void TestContinueButton_ValidInput()
        {
            UserForm userForm = new UserForm(new User());
            userForm.nameTextBox.Text = "John";
            userForm.cashTextBox.Text = "1000";
            userForm.continueButton_Click(null, null);
            Assert.IsTrue(userForm.IsDisposed);
        }
    }
}
