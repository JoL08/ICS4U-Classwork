// IF STATEMENTS
// 1. Ask the user how old they are. If they are 18+, output they can vote, and another message if they can't.

using System;
public class Program
{
    public static void Main(string[] args)
   {
        Console.Write("Your age: ");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18){
            Console.WriteLine("You can vote.");
        }
        else{
            Console.WriteLine("You cannot vote.");
        }

   }
}
