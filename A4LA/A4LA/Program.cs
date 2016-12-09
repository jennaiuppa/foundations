using System;

class Program
{
    static void Main()
    {
        int n, fact = 1, result;

        Console.Write("Enter a small number of factorials you wish to display ");
        result = int.Parse(Console.ReadLine());


        for (n = 1; n <= result; n++)
        {
            fact = fact * n;
            Console.WriteLine("{0}!={1}", n, fact);

        }
        Console.ReadLine();
    }
}