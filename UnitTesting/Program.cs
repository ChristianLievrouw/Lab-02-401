using System;

namespace UnitTesting
{
   public class Program
    {
        public static decimal Balance = 100.00m;

        static void Main(string[] args)
        {
            Options();
        }
        public static decimal ViewBalance(decimal balance)
        {
            Console.WriteLine("Yuor currant balance is: {0}", balance);
            Balance = balance;
            return balance;
        }

        public static decimal Withdraw(decimal withdraw, decimal balance)
        { 
            balance -= withdraw;
            Console.WriteLine("Withdraw Amount: {0}", withdraw);
            Console.WriteLine("Remaining Amount {0}", balance);
            Balance = balance;
            return balance;
        }

        public static decimal Deposit(decimal deposit, decimal balance)
        {
            balance += deposit;
            Console.WriteLine("Deposite amount: {0}", deposit);
            Balance = balance;
            return balance;
        }

        public static void BadCommand()
        {
            Console.WriteLine("Bad Entry... Restarting...");
            Options();
        }

        public static void Options()
        {
            Console.WriteLine("Would you like to view balance, withdraw, deposit, exit");
            string input = Console.ReadLine();
            if (input != "exit")
            {
                if (input == "view balance")
                {
                    ViewBalance(Balance);
                    Options();
                }

                else if (input == "withdraw")
                {
                    Console.WriteLine("Your balance is: {0}", Balance);
                    Console.WriteLine("How much would you like to withdraw? ");
                    string inputString = Console.ReadLine();
                    decimal userWithdraw = Convert.ToDecimal(inputString);
                    if (userWithdraw > Balance)
                    {
                        Console.WriteLine("Insufficient funds");
                        Options();
                    }
                    else
                    {
                        Withdraw(userWithdraw, Balance);
                        Console.WriteLine("New balance: {0}", Balance);
                        Options();
                    }
                }

                else if (input == "deposit")
                {
                    Console.WriteLine("Your balance is: {0}", Balance);
                    Console.WriteLine("How much would you like to deposit? ");
                    string inputString = Console.ReadLine();
                    decimal userInput = Convert.ToDecimal(inputString);
                    Deposit(userInput, Balance);
                    Console.WriteLine("New balance: {0}", Balance);
                    Options();
                }
                else
                {
                    Console.WriteLine("Incorrect command");
                    Console.WriteLine();
                    Options();
                }
            }
        }
    }
}

