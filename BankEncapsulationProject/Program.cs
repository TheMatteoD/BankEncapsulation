using System;

namespace BankEncapsulationProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            bool atBank = true;

            while (atBank)
            {
                Console.WriteLine($"Welcome to the bank!");
                Console.WriteLine($"Type '1' to deposit money");
                Console.WriteLine($"Type '2' to check your balance");
                bool enteredNumber = int.TryParse(Console.ReadLine(), out int response);

                if (enteredNumber)
                {
                    if (response == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("How much are you depositing today?");
                        bool enteredAmount = double.TryParse(Console.ReadLine(), out double amount);
                        if (enteredAmount)
                        {
                            bankAccount.Deposit(amount);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input");
                        }
                        Console.Clear();
                    }
                    if (response == 2)
                    {
                        Console.Clear();
                        Console.WriteLine($"You currently have {bankAccount.GetBalance()} dollars in your account.");
                        Console.WriteLine("----------------------------------------------");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("! Enter either '1' or '2' !");
                    Console.WriteLine("----------------------------------------------");
                }


            }



        }
    }
}
