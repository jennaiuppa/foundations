// Class Exercise No. 1 - Create a basic RPN Calculator
// Make use of Class Stack to create your Class RPN Calculator 
using System;

class Stack // done
{
    private int[] stack = new int[10];
    private int sp = 0;

    public void Push(int v) // dynamically grows
    {
        stack[sp++] = v;

        // step 1: identify if exceeding the length
        if (sp == stack.Length)
        {
            // step 2: create a new array with a longer length
            int n = stack.Length * 2;
            int[] newstack = new int[n];

            // step 3: copy the old into new
            stack.CopyTo(newstack, 0);

            // step 4: toss the old stack away
            stack = newstack;
        }
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

    public int Pop()
    {
        return stack[--sp];
    }
}

class RPN // design RPN
{
    private Stack stack = new Stack(); // create an object of class Stack

    public void Process(string str)
    {
        switch (str)
        {
            case "+": // when user wants to add the last two numbers
                {
                    // do the code to add the last two numbers 
                    // and save it in the stack
                    int v1 = stack.Pop();
                    int v2 = stack.Pop();
                    int sum = v2 + v1;
                    stack.Push(sum);
                    break; // do not forget to break
                }
            case "-": // when user wants to subtract the last two numbers
                {
                    // do the code to subtract the last from previous
                    // and save it in the stack
                    int v1 = stack.Pop();
                    int v2 = stack.Pop();
                    int sum = v2 - v1;
                    stack.Push(sum);
                    break;
                }
            default: // when user enters a number
                {
                    // places the number into the stack
                    // since the input is coming in as string
                    // you need to convert it into an interger type first
                    // then push the interger into the stack
                    // so....

                    // step 1: convert str into an int v
                    int v = int.Parse(str);

                    // step 2: push into the stack
                    stack.Push(v);

                    break;
                }
        }
    }

    public int Result
    {
        get
        {
            // do the code to return the last value
            // return the top value (or the result)
            return stack.Top;
        }
    }
}

class ex17
{
    public static void Main()
    {
        RPN rpn = new RPN();

        while (true)
        {
            string str;

            Console.Write("RPN>");
            str = Console.ReadLine();

            rpn.Process(str);

            Console.WriteLine("={0}", rpn.Result);
        }
    }
}