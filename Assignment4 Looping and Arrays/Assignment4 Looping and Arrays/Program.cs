//Assignment #4: Looping and Arrays
// Definition: The factorial of an integer n, written n!, is the product of the consecutive integers 1 through n.  For example, 5 factorial is calculated as: 5! = 5 x 4 x 3 x 2 x 1 = 120.

using System;

class Factorial
{
    static void Main()
    {
        //delcare values
        {
            int n, number, result;

            //ask to enter a number
            Console.Write("Please enter a number");
            number = int.Parse(Console.ReadLine());
            result = number;

            //calculate factorial and save
            for (n = number - 1; n >= 1; n--)
            { result = result * n; }

            Console.WriteLine();
        }
    }
}

        //show result in an array
    
