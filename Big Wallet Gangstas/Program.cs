// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Big Wallet Gangstas");

        Console.WriteLine("As the newest member of the Big Wallet Gangstas crime family, you are expected to be a good earner.");

        Console.WriteLine("Every day you will come here to deposit your tribute.");



        List<decimal> moneyList = new List<decimal>();
        decimal total = 0;

        while (true)
        {
            Console.Write("Enter a money value (or 'exit' to quit): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                break;
            }

            if (decimal.TryParse(userInput, out decimal moneyValue))
            {
                moneyList.Add(moneyValue);
                total += moneyValue;

                Console.WriteLine("Running Total: " + total);

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        Console.WriteLine("Money values entered:");
        foreach (decimal moneyValue in moneyList)
        {
            Console.WriteLine(moneyValue);
        }

        Console.WriteLine("Final Total: " + total);
    }
}
