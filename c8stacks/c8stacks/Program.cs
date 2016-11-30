// Arrays_Stacks.cs
using System;

class Stack
{
    private int[] stack = new int[10]; //size 10
    private int sp = 0; //sp- stack pointer

    public void Push(int v)
    { //stack [sp]= v (value) //put the value in
      //sp =sp+1 //move the stack pointer to the next available spot 

        stack[sp++] = v;
    }

    public int Pop()
    {

        //move the stackpointer down by one and then return the stack value at that point 
        return stack[--sp];
    }

    public int Top //the last value entered into the stack - NOT necessarily the length of the stack 
    {
        get
        {
            return stack[sp - 1];
        }
    }

    public bool IsEmpty
    {
        get
        {  //if the stack point is at zero we know the stack is empty  can rewrite as (if sp==0) {return true;}
            return sp == 0; //takes care of this in the body - return true if this statement is true - if stack is empty 
        }
    }
}

class Arrays_Stacks
{
    static void Main()
    {
        Stack stack = new Stack();

        stack.Push(5);
        stack.Push(3);
        stack.Push(2);
        stack.Push(9);

        Console.WriteLine("The last value pushed was {0}", stack.Top);

        while (!stack.IsEmpty) //as long as my stack is not empty - pop. 
        {
            Console.WriteLine("Popping {0}", stack.Pop());
        }

        Console.Write("Press Enter...");
        Console.ReadLine();
    }
}