// Arrays_Stacks.cs
using System;

class Stack
{
    private int[] stack = new int[10];
    private int sp = 0;

    public void Push(int v)
    {
        stack[sp++] = v;
        //step 1 identify if exceeding the length
        if (sp == stack.Length);

        {
            //step 2 - create a new array with a longr length
            int n = stack.Length * 2;
            int[] newstack = new int[n];

            //step 3 - copy the old into new
            stack.CopyTo(newstack, 0);

            //step 4 - toss the old stack away
            stack = newstack;

 }
    }

    public int Pop()
    {
        return stack[--sp];
    }

    public int Top
    {
        get
        {
            return stack[sp - 1];
        }
    }

    public bool IsEmpty
    {
        get
        {
            return sp == 0;
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
        stack.Push(5);
        stack.Push(3);
        stack.Push(2);
        stack.Push(9);
        stack.Push(5);
        stack.Push(3);
        stack.Push(2);
        stack.Push(9);
        stack.Push(5);
        stack.Push(3);
        stack.Push(2);
        stack.Push(9);
        stack.Push(5);
        stack.Push(3);
        stack.Push(2);
        stack.Push(9);
        stack.Push(5);
        stack.Push(3);
        stack.Push(2);
        stack.Push(9);

        Console.WriteLine("The last value pushed was {0}", stack.Top);

        while (!stack.IsEmpty)
        {
            Console.WriteLine("Popping {0}", stack.Pop());
        }

        Console.Write("Press Enter...");
        Console.ReadLine();
    }
}