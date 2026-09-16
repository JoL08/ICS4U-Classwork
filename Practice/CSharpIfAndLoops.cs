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

// 2. Create a program that will take user input for the weekday number 0-6
//     and output what day of the week that is 0 - Sunday .. 6 - Saturday.
//     If they input an invalid, also tell them that.
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter weekday: ");
        int dayNum = int.Parse(Console.ReadLine());
        string[] WEEKDAY = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        if (dayNum >= 0 && dayNum <= 6) {
            Console.WriteLine(WEEKDAY[dayNum]);
        } else {
            Console.WriteLine("Invalid weekday");
        }
    }
}

// LOOPS
// 1. Count from 0 - 99 using a while loop and a for loop.
using System;
public class Project
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++){
            Console.WriteLine(i);
        }
        
        int j = 0;
        while (j < 100){
            Console.WriteLine(j);
            j++;
        }
    }
}

// 2. Add up the multiples of 3 from 0-100. Print the result.
using System;
public class Project {
    public static void Main(string[] args) {
        int total = 0;
        for (int i = 0; i < 101; i += 3){
            total += i;
        }
        
        total = 0;
        for (int k = 0; k < 100; k++){
            if (k % 3 == 0){
                total += k;
            }
        }
        Console.WriteLine(total);
    }
}

// 3. Add up the multiples of both 3 and 7 from 0-100. Print the result.
using System;
public class Project
{
    public static void Main(string[] args)
    {
        int sum = 0;
        for (int a = 0; a < 101; a++){
            if (a % 3 == 0 && a % 7 == 0){
                sum += a;
            }
        }
        Console.WriteLine(sum);
    }
}
