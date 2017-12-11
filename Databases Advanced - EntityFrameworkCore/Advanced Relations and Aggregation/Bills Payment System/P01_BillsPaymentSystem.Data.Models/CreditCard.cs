using System;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }

        public decimal Limit { get; private set; }

        public decimal MoneyOwed { get; private set; }

        public decimal LimitLeft => (this.Limit - this.MoneyOwed);

        public DateTime ExpirationDate { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount should not be negative.");
            }
            if (amount > this.LimitLeft)
            {
                throw new ArgumentException("Insufficient funds!");
            }

            this.Limit -= amount;
            this.MoneyOwed += amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount should not be negative.");
            }

            if(MoneyOwed - amount >= 0)
            this.MoneyOwed -= amount;
            else
            {
                this.MoneyOwed = 0;
                amount -= this.MoneyOwed;
                Limit += amount;
            }
        }

        public override string ToString()
        {
            return $"--ID: {this.CreditCardId}" + Environment.NewLine +
                   $"--- Limit: {this.Limit:f2}" + Environment.NewLine +
                   $"--- Money Owed: {this.MoneyOwed:f2}" + Environment.NewLine +
                   $"--- Limit Left:: {this.LimitLeft:f2}" + Environment.NewLine +
                   $"--- Expiration Date: {this.ExpirationDate.Year} / {this.ExpirationDate.Month}";
        }
    }
}
