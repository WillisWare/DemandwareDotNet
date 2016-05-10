using System;
using System.Linq;
using Net.Demandware.Ocapi.Documents.Data;
using Net.Demandware.Ocapi.Resources.Data;

namespace DemandwareQueryUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            while ((input = PromptUser()) > 0)
            {
                ProcessInput(input);
            }
        }

        private static int PromptUser()
        {
            Console.WriteLine("You may select from the following options:");
            Console.WriteLine("1: Get Customer Details");
            Console.WriteLine("0: Quit");
            Console.WriteLine();
            Console.Write("Enter Selection: ");

            int input;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                return 0;
            }

            return input;
        }

        private static void ProcessInput(int input)
        {
            switch (input)
            {
                case 1:
                    Console.Write("Please enter the customer ID: ");
                    var customerId = Console.ReadLine();

                    try
                    {
                        var resource = new CustomerSearch();
                        var result = resource.Search(new CustomerSearchRequest
                        {
                            Count = 10,
                            Query = $"email = '{customerId}'",
                            Select = "(**)",
                            StartIndex = 0
                        });
                        Console.WriteLine($"The customer is {result.Data.First()}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();
        }
    }
}
