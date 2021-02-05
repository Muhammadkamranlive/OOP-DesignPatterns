﻿using static System.Console;

namespace _02_CompositeCommand
{
    public class BankAccount
    {
        private int balance;
        private int overdraftLimit = -500;

        public BankAccount(int balance = 0)
        {
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            balance += amount;
            WriteLine($"Deposited ${amount}, balance is now {balance}");
        }

        public bool Withdraw(int amount)
        {
            if (balance - amount >= overdraftLimit)
            {
                balance -= amount;
                WriteLine($"Withdrew ${amount}, balance is now {balance}");
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
