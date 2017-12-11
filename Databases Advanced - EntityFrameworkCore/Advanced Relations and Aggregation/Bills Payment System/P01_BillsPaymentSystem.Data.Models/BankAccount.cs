using System;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }

        public decimal Balance { get; private set; }

        public string BankName { get; set; }

        public string SwiftCode { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }


        public BankAccount()
        {

        }

        public BankAccount(string bankName, string swiftCode)
        {
            this.BankName = bankName;

            this.SwiftCode = swiftCode;
        }
        public void Withdraw(decimal amount)
        {

            if (amount < 0)
            {
                throw new ArgumentException("Amount should not be negative.");
            }
            if (amount > this.Balance)
            {
                throw new ArgumentException("Insufficient funds!");
            }
            this.Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount should not be negative.");
            }

            this.Balance += amount;
        }

        public override string ToString()
        {
            return $"--ID: {this.BankAccountId}" + Environment.NewLine +
                   $"--- Balance: {this.Balance:f2}" + Environment.NewLine +
                   $"--- Bank: {this.BankName}" + Environment.NewLine +
                   $"--- SWIFT: {this.SwiftCode}";
        }
    }
}
