using System;

class BankAccount
{
    //create the balance field
    private decimal balance;

    //create a construtor
    public BankAccount()
    {
        balance = 0; //start with zero balance
    }


    //create the deposit function

    public void Deposit (decimal deci)
    {
        balance = balance + deci;
    }
    //create the withdrawl function
    public void Withdrawl (decimal deci)
    {
        balance = balance - deci;
    }
    //create an accessing function to find what your current balance is 
    public decimal GetBalance() //returns the balance in decimal
    { return balance;
    }
}

class Test
{
    static void Main ()
    {
        BankAccount acct = new BankAccount();

        acct.Deposit(200m);
        acct.Withdrawl(40m);

        Console.WriteLine("The final balance is {0}", acct.GetBalance());
        Console.ReadLine();
    }
}