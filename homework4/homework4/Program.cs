using System;

namespace homework4
{
    class Program
    {
        static void Main()
        {

            int result = 0;
            int[] numbers = new int[5];

            for (int n = 0; n < numbers.Length; n++)
            {
                numbers[n] = n + 1;

                if (result > 0)
                {
                    result = (numbers[n]);
                }

                else
                {
                    result = 1;
                }
                Console.ReadLine();
            }
            
        }
    }
}
    

