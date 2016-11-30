using System;

class Program
{
    static void Main()
    {
        int n, number, result;
        Console.Write("Enter the number of factorials you wish to display ");
        number = int.Parse(Console.ReadLine());
        





        for (int= n-1; n > 1; n--)
        {
            if (result > 0)
            {
                result = (n + 1) * result;
            }



            Console.WriteLine("{0}! = {1}", n, result);
            Console.ReadLine();
        }
    }
    }
