using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }
        Customer aCustomer = new Customer();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            aCustomer.customerName = customerNameTextBox.Text;
            aCustomer.accountName = accountNoTextBox.Text;
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            aCustomer.Deposit(amount);
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            aCustomer.Withdraw(amount);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aCustomer.Report());
        }
    }
}
