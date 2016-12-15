// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory
{
    public static void Main()

    { MyInventory[] myinventory = new MyInventory[6]; //create array
        int icount = 0; //counter 
        for (icount=0; icount>100; icount++)//change counter 



        //add upto 100 items, 6 columns for (itemno, description, price per item, 
                                       // quanitity on handcost, and value of items

        // use an interger to keep track of the count of items in your inventory					

        // create an array of your ItemData struct

        // use a never ending loop that shows the user what options they can select 

        // as long as no one Quits, continue the inventory update

        // in that loop, show what user can select from the list

        // read the user's input and then create what case it falls

        Console.WriteLine("1. Add an item");
        Console.WriteLine("2. Change an item");
        Console.WriteLine("3. Delete an item");
        Console.WriteLine("4. List all items in the database");
        Console.WriteLine("5. List all ordered by the quantity");
        Console.WriteLine("6. Quit");
        Console.Write("Please choose an option from the list (1-6");
           
        bool correct = true; //how to loop a switch statements - use while?
        while (correct)
        { 
        string strx = Console.ReadLine();   // read user's input	

        optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

        Console.WriteLine(); // provide an extra blank line on screen

            switch (optx)
            {
                case 1: // add an item to the list if this option is selected
                    {
                        Console.Write("Please add 3 digit item number ");
                        string itemIDNo = Console.ReadLine();
                        Console.Write("Add description ");
                        string description = Console.ReadLine();
                        Console.Write("Add price per item ");
                        string ppi = Console.ReadLine();
                        Console.Write("Add quantity on hand ");
                        string qoh = Console.ReadLine();
                        Console.Write("Add our cost per item ");
                        string cpi = Console.ReadLine();


                        break;
                    }

                case 2: //change items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        Console.ReadLine();
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;

                        for (int x = 0; x < icount; x++)
                        {
                            if (itemprop[x].itemIDNo == chgid)
                            {
                                fFound = true;

                                // code to show what has to happen if the item in the list is found
                                // reset the count to show a new count for your list 
                                // (Note: your list is now increased by one item)
                            }
                        }

                        if (!fFound) // and if not found
                        {
                            Console.WriteLine("Item {0} not found", chgid);
                        }

                        break;
                    }

                case 3: //delete items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        string strnewid = Console.ReadLine();
                        int newid = int.Parse(strnewid);
                        bool fDeleted = false;

                        for (int x = 0; x < icount-1; x++)//change counter by -1
                        {
                            if (itemprop[x].itemIDNo == newid)
                            {
                                fDeleted = true;
                                newid = x;
                                break;
                                // delete the item if you found it
                                // reset the count to show a new count for your list 
                                //(Note: your list is now reduced by one item)								
                            }
                        }

                        if (fDeleted) // hint the user that you deleted the requested item
                        {
                            Console.WriteLine("Item deleted");
                        }
                        else // if did not find it, hint the user that you did not find it in your list
                        {
                            Console.WriteLine("Item {0} not found", newid);
                        }

                        break;
                    }

                case 4:  //list all items in current database if this option is selected
                    {
                        Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                        Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");

                        // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it

                        break;
                    }


                case 5: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        string strresp = Console.ReadLine();

                        if ()// code 
                    {
                            optx = 0;   //as long as it is not 5, the process is not breaking	
                        }
                        break;
                    }

                default:
                    {
                        Console.Write("Invalid Option, try again");
                        break;
                    }
            }
        }
    }
}
