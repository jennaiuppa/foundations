using System;


class Program
{
    static void Main()
    {

        //declare values
        {
            int n, number, result;

            //ask to enter number
            Console.Write("Please enter a small number to calculate the Factorial ");
            number = int.Parse(Console.ReadLine());
            result = number;


            //calculate factorial and save
            for (n = number - 1; n >= 1; n--)


            {//start of loop
                result = result * n;
            }//end of loop


            //show result
            Console.Write("The facortial is {0} ", result);

            //hold result
            Console.ReadLine();
        }
    }
}