using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack polishNotationStack = new Stack();//a stack of type int
            //the expression will be a string array
            string[] expression = { "/", "2", "*", "+", "4", "3", "5" };//first, a prefix expression
            for (int i = 0; i < expression.Length; i++)//we write the prefix expression
            {
                Console.Write(expression[i]);
            }
            int result;//a result to push onto the stack after an operation was done

            Console.WriteLine();//newline space
            Array.Reverse(expression);//we reverse the expression to read in the characters from right to left
            int n;
            foreach (string c in expression)//for each string character in the array
            {
                if (int.TryParse(c, out n))//if the character can be converted to a number (operand)
                {
                    polishNotationStack.Push(n);//push the number onto the stack
                }
                if (c == "+")//handling of operators
                {
                    int x = (int)polishNotationStack.Pop();
                    int y = (int)polishNotationStack.Pop();
                    result = x + y;//evaluate the values popped from the stack
                    polishNotationStack.Push(result);//push current result onto the stack
                }
                if (c == "-")
                {
                    int x = (int)polishNotationStack.Pop();
                    int y = (int)polishNotationStack.Pop();
                    result = y - x;
                    polishNotationStack.Push(result);
                }
                if (c == "*")
                {
                    int x = (int)polishNotationStack.Pop();
                    int y = (int)polishNotationStack.Pop();
                    result = x * y;
                    polishNotationStack.Push(result);
                }
                if (c == "/")
                {
                    int x = (int)polishNotationStack.Pop();
                    int y = (int)polishNotationStack.Pop();
                    result = y / x;
                    polishNotationStack.Push(result);
                }

            }
            /*write the final result of the expression,
             * which is at the top of the stack, so we use Peek()*/
            Console.WriteLine("result of expression: {0}", polishNotationStack.Peek());

            Console.ReadLine();
        }
   

    }
}
