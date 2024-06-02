using System;

class TicketPriceCalculator
{
    static void Main()
    {
        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Attempt to parse the input as an integer
        if (int.TryParse(input, out int age))
        {
            // Determine the ticket price based on the age
            int ticketPrice = GetTicketPrice(age);

            // Display the ticket price
            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
        else
        {
            // Invalid input
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }

    static int GetTicketPrice(int age)
    {
        int ticketPrice;
        
        // Use a switch statement to determine the ticket price
        switch (age)
        {
            case int n when (n <= 12):
            case int n when (n >= 65):
                ticketPrice = 7; // Discounted price for children and senior citizens
                break;
            default:
                ticketPrice = 10; // Regular price
                break;
        }

        return ticketPrice;
    }
}
