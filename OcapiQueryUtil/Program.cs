using System;
using System.Linq;
using Net.Demandware.Ocapi.Documents.Data;
using Net.Demandware.Ocapi.Resources.Data;

namespace Net.Demandware.Ocapi.Util
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
            Console.WriteLine(Properties.Resources.Prompt_Menu_Select_Option);
            Console.WriteLine();
            Console.WriteLine($"1: {Properties.Resources.Prompt_Menu_Get_Customer_Details}");
            Console.WriteLine($"0: {Properties.Resources.Prompt_Menu_Quit}");
            Console.WriteLine();
            Console.Write($"{Properties.Resources.Prompt_Menu_Enter_Selection}: ");

            int input;
            return (!int.TryParse(Console.ReadLine(), out input) ? 0 : input);
        }

        private static void ProcessInput(int input)
        {
            switch (input)
            {
                case 1:
                    Console.Write("Please enter the customer ID: ");
                    var customerId = Console.ReadLine();

                    SearchCustomers(customerId);
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();
        }

        private static void SearchCustomers(string customerId)
        {
            try
            {
                var resource = new CustomerSearch();
                var result = resource.Search(new CustomerSearchRequest
                {
                    Count = 10,
                    Query = $"email ILIKE '{customerId}'",
                    Select = "(**)",
                    StartIndex = 0
                });
                Console.WriteLine($"{result.Count} customer(s) matched your criteria.");

                if (result.Count > 0)
                {
                    var customer = result.Data.First();
                    Console.WriteLine($"The first customer is {customer.LastName}, {customer.FirstName}: {customer.Email} (ID: {customer.Id})");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
