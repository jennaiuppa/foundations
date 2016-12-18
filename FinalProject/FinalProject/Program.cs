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
    {
        ItemData[,] itemdata = new ItemData[100,6];
        itemdata[0,0].itemIDNo= 0;
        itemdata[0, 1].sDescription = null;
        itemdata[0,2].dblPricePerItem = 0;
        itemdata[0,3].iQuantityOnHand = 0;
        itemdata[0,4].dblOurCostPerItem =0 ;
        itemdata[0, 5].dblValueOfItem = 0;

        foreach (ItemData i in itemdata)
        {
            Console.WriteLine("{0}{1}{2}{3}{4}{5}", i.itemIDNo, i.sDescription, i.dblValueOfItem, i.iQuantityOnHand, i.dblValueOfItem, i.dblValueOfItem);
   }
    
        // use an interger to keep track of the count of items in your inventory					

        // create an array of your ItemData struct

        // use a never ending loop that shows the user what options they can select 

        // as long as no one Quits, continue the inventory update

        // in that loop, show what user can select from the list

        // read the user's input and then create what case it falls

        Console.WriteLine("1.  Add an item");
        Console.WriteLine("2.  Change an item");
        Console.WriteLine("2.  Delete an item");
        Console.WriteLine("4.  List list all items in current database");
        Console.WriteLine("5.  Quit");
        Console.WriteLine("");
        Console.WriteLine("Please choose an option in the list (1-5");

     
        string strx = Console.ReadLine();   // read user's input	

        int optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

        Console.WriteLine(); // provide an extra blank line on screen

        switch (optx)
        { 

            case 1:	// add an item to the list if this option is selected
                {

                    Console.WriteLine("Please enter item ID No (3 digits      ");
                    string itemIDNo = Console.ReadLine();
                    Console.WriteLine("Please enter item description");
                    string sdescription = Console.ReadLine();
                    Console.WriteLine("Please enter the Item Price:          ");
                    string dblPricePerItem = Console.ReadLine();
                    Console.WriteLine("Please enter the quanitity on hand:  ");
                    string iQuantityOnHand = Console.ReadLine();
                    Console.WriteLine("Please enter our cost per item");
                    string dblOurCostOfItem = Console.ReadLine();

                    break;
                }

            case 2: //change items in the list if this option is selected
                {
                    Console.Write("Please enter an item ID No:");
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

                    for (int x = 0; x < icount; x++)
                    {
                        if (itemprop[x].itemIDNo == newid)
                        {
                            fDeleted = true;
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

            case 4:	 //list all items in current database if this option is selected
                {
                    Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                    Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");

                    Foreach(ItemData i in itemdata)
                    Console.WriteLine("{0}       {1}       {2}            {3}     {4}", i.itemIDNo, i.sDescription, i.dblPricePerItem, i.iQuantityOnHand, i.dblOurCostPerItem);
                    Console.ReadLine();

                    // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it

                    break;
                }


            case 5: //quit the program if this option is selected
                {
                    Console.Write("Are you sure that you want to quit(y/n)?");
                    string strresp = Console.ReadLine();

                    if (x = 5)// code )
                    {
                        optx = 0;	//as long as it is not 5, the process is not breaking	
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
