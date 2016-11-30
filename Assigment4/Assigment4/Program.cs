using System;

class Program
{
    static void Main()
    {
        int n = 0, result = 0, number = 0;
        Console.Write("Enter the number of factorials you wish to display");
        int arraylength = int.Parse(Console.ReadLine());
        int[] fact = new int[arraylength];

        result = number;
        number = number - 1;
        while (number > 0)
        {
            result *= number;
            number--;
        }

        Console.WriteLine("{0}! = {1}", n, Factorial(n));
        Console.ReadLine();

    }
}