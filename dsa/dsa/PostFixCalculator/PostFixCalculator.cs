using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dsa.Stack;

namespace dsa.PostFixCalculator
{
    class PostFixCalculator 
    {
        Stack.Stack stack = new Stack.Stack();

        public void Calculate(string[] args)
        {
            foreach (string token in args)
            {
                int value;
                if (int.TryParse(token, out value))
                {
                    stack.Push(value);
                }
                else
                {
                    int rhs = stack.Pop();
                    int lhs = stack.Pop();

                    switch(token)
                    {
                        case "+":
                            stack.Push(lhs + rhs);
                            break;
                        case "-":
                            stack.Push(lhs - rhs);
                            break;
                        default:
                            throw new ArgumentException("Bad Argument");
                    }
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
