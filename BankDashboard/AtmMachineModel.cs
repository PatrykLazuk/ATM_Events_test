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
    public partial class AtmMachineModel : Form
    {
        private AccountModel account;

        public AtmMachineModel()
        {
            InitializeComponent();
        }

        public AtmMachineModel(AccountModel account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void bWithdrawButton_Click(object sender, EventArgs e)
        {
            account.TransferMoneyFromAccount(nValueOfTransfer.Value);
        }
    }
}
