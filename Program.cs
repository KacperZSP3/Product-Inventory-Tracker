// Instructions:
// A store has a product inventory system. If a product is sold, it reduces the quantity in stock.
// If the stock is zero, the system should indicate "Out of Stock".
// Example:
// Input: Initial stock = 5, Sold = 6
// Output: Out of Stock

using System;

class Program
{
    static void Main()
    {
        int stock = 5;

        Console.WriteLine("Enter the number of items sold:");
        int sold = Convert.ToInt32(Console.ReadLine());

        stock -= sold;

        if (stock > 0)
        {
            Console.WriteLine("Out of Stock");
        }
        else
        {
            Console.WriteLine($"Remaining stock: {stock}");
        }
    }
}
