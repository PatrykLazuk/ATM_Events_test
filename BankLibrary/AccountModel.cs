using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class AccountModel
    {
        public event EventHandler<AccountEventArgs> BalanceChangedEvent;

        public string AccoutnName { get; set; }
        public decimal AccountBalance { get; private set; } = 0.00M;

        private string _typeOfAction;
        public void TransferMoneyToAccount(decimal value)
        {
            _typeOfAction = "Transfer To";
            AccountBalance += value;
            BalanceChangedEvent?.Invoke(this, new AccountEventArgs() {TypeOfAction = _typeOfAction, AccountBalance = AccountBalance, TransferValue = value });
            _typeOfAction = null;
        }

        public void TransferMoneyFromAccount(decimal value)
        {
            _typeOfAction = "Transfer from";
            if (AccountBalance>=value)
            {
                AccountBalance -= value;
                BalanceChangedEvent?.Invoke(this, new AccountEventArgs() { TypeOfAction = _typeOfAction, AccountBalance = AccountBalance, TransferValue = value });
            }
            _typeOfAction = null;
        }
    }
}
