using System;




    class Program
{
    static void Main()
    {//setup array

        int[] aNum = new int[] { 0, 2, 5, 100, -1, 4, 8, -5 };

        //delare a min and max 
        int Min;
        int Max;

        //assume the first value 
        //array is the Min and Max value
        //work from there

        Max = aNum[0];//pick on the fit number in the group
        Min = aNum[0];//""

        //need to create a looping method to go throuh the Min and Max


        foreach (int x in aNum)
        {

            //find the min
            if (x < Min)
            {
                Min = x;

            };

            //find the Max
            if (x > Max)
            {
                Max = x;
            }
        }


                    //is greater than the max)
                     //Find the Max

                    Console.WriteLine("The Miniumum value is {0}", Min);
        Console.WriteLine("The Maximum value is {0}", Max);
        Console.ReadLine();

    }
    }

