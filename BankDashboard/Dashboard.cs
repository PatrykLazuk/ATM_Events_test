using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDashboard
{
    public partial class Dashboard : Form
    {
        AccountModel account = new AccountModel();
        public Dashboard()
        {
            account.BalanceChangedEvent += Account_BalanceChangedEvent;
            InitializeComponent();
            GetDemoData();
            SetUpDashboard();
            
        }

        private void Account_BalanceChangedEvent(object sender, AccountEventArgs e)
        {
            lbAccoutActions.Items.Add($"Operation: {e.TypeOfAction},value of transfer: {e.TransferValue:C2}");
            lAccountBalanceValue.Text = $"{account.AccountBalance:C2}";
        }

        private void SetUpDashboard()
        {
            lAccountBalanceValue.Text = $"{account.AccountBalance:C2}";
            lOwnerName.Text = account.AccoutnName;
        }

        private void GetDemoData()
        {
            account.AccoutnName = "Konto Patryka";
            account.TransferMoneyToAccount(100M);
        }

        private void bATM_Click(object sender, EventArgs e)
        {
            AtmMachineModel ATM = new AtmMachineModel(account);
            ATM.Show();
        }
    }
}
