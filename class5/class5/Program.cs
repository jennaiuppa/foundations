using System;

class Average
{
    static void Main()
    {//define variable for summation

        float fsum = 0.0f;
        //define variable for average

            float favg;
        //start up the for loop and allow for 10 entries
        for(int x=1; x<=10; x++) 
        {//beging of loop
            Console.Write("Please enter a number {0} of 10: ",x);
            string strnum = Console.ReadLine();
            float n = float.Parse(strnum);
            fsum = fsum + n;
        }//end of loop

        //after summing them within the loop, find the average 
        favg = fsum / 10;
        
        //show results on console 
        Console.WriteLine("The averae of the given numbers is {0}", favg);
        Console.ReadLine();


    }

} 