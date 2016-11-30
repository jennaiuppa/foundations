using System;

class Program
{
    static long Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }
    static void Main(string[] args)
    {
        int n, number=0, result;

        Console.Write("Enter a number to determine a factorial ");
        int.Parse(Console.ReadLine());
        result = number;


        for ( n = number -1; n < 0; n++)
            Console.WriteLine("{0}! = {1}", n, Factorial(n));
        Console.ReadLine();
    }
}