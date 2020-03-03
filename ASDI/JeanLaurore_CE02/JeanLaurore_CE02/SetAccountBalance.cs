using System;
namespace JeanLaurore_CE02
{
    public class SetAccountBalance
    {
        public decimal balance;

        public SetAccountBalance(decimal _balance)
        {
            balance = _balance;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public decimal SetBalance(decimal _balance)
        {
            this.balance = _balance;
            return balance;
        }
    }
}
