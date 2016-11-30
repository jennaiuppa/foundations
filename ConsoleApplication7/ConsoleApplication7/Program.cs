using System;

class newProgram
{

    /* Here's the explaination of the functions:
	*  Main(): User interface that prompts for the input and displays the results in a table in ascending order.
	*  factorial(): function that takes an int and calculates the factorial and returns the answer.
	*/
    static void Main()
    { 

        int i,number,factorial; // Setup variables

        Console.Write("Please enter a small number to calculate the Factorial "); // Prompt user for input
        number = int.Parse(Console.ReadLine()); // Assign user input to 'number'

        for (int i = 1; i < number; i++)
        { // This is the loop to create the ascending answer table from 1! through the input's !
            Console.Write("{0}! = {1}", i, factorial(i)); // Output each line and increment. We are calling the factorial() function and passing it the key from the loop
            Console.ReadLine();
        }

    }

 