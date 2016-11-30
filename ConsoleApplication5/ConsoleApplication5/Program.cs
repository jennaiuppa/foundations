using System;

class s6ex2
{
    static void Main()
    {
        Console.Write(" Here is the multiplication for 5x5 table: ");
        Console.WriteLine();
        Console.WriteLine();

        int x;
        int y;

        for (x = 1; x <= 5; x++) //x rows, marches vertically one row at a time
        {
            for (y = 1; y <= 5; y++) // y columns, marches horizontally as spaced below
            {
                int z = x * y;
                // {0,6} indicates 6 spaces for parameter zero
                Console.Write("{0,6}", z);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}