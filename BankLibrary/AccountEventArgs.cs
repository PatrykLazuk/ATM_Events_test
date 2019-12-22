using System;

namespace BankLibrary
{
    public class AccountEventArgs : EventArgs
    {
        public string TypeOfAction { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal TransferValue { get; set; }
    }
}