using System;

class Program
{
    static void Main()
    {
        int n, number, result;
        Console.Write("Enter the number of factorials you wish to display ");
        number = int.Parse(Console.ReadLine());
        result = number;

        for (n = number - 1; n >= 1; n--)
        {
            result = result * n;
        }


    }

   

}