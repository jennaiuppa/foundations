using System;

class BankAccount;
{
//create the balance field
private decimal balance;

//creat a constructor
public BankAccount()
{
    balance = 0; //start with 0 balance

}

//create deposit function
public void Deposit (decimal deci)
{

    balance = balance + deci;

}

//creat a withdrawl function
public void Withdrawl (decimal deci)
{ 

balance = balance- deci;

}
 //create accessing function to find what your currentl balance is 