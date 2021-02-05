using System;

namespace _03_Exercise
{

    public class Command
    {
        public Action TheAction;
        public int Amount;
        public bool Success;

        public enum Action
        {
            Deposit,
            Withdraw
        }
    }

    public class Account
    {
        public int Balance { get; set; }

        public void Process(Command c)
        {
            switch(c.TheAction)
            {
                case Command.Action.Deposit:
                    Balance += c.Amount;
                    c.Success = true;
                    break;
                case Command.Action.Withdraw:
                    if (c.Amount > Balance)
                        c.Success = false;
                    else
                    { 
                        Balance -= c.Amount;
                        c.Success = true;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
