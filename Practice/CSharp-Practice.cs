 // Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the cost: $");
        float cost = float.Parse(Console.ReadLine());
        Console.Write("Enter the quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        float subtotal = cost * quantity;
        float tax = subtotal * 0.13f;
        float total = subtotal + tax;
        Console.WriteLine($"Subtotal: ${subtotal}");
        Console.WriteLine($"Tax: ${tax}");
        Console.WriteLine($"Total: ${total}");
        
    }
}
