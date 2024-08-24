using System;
using System.Collections.Generic;

namespace Proj5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for the input
            Console.Write("Input your string: ");
            string input = Console.ReadLine();
            //Output the result
            if (CheckBracket(input))
                Console.WriteLine("Sucess");
            else
                Console.WriteLine("Flase: Not all brackets match properly");

            //Function to check completenss of brackets
            bool CheckBracket(string s)
            {
                
                //List to store bracket completion
                List<string> myList = new List<string>();
                myList.Add("()");
                myList.Add("{}");
                myList.Add("[]");
                char[] charArray = s.ToCharArray();
                Stack<char> myStack = new Stack<char>();
                foreach(char c in s)
                {
                    myStack.Push(c);
                }
                foreach(char c in myStack)
                {
                    if (c == ')' && !myStack.Contains('('))
                        return false;
                    else if (c == '}' && !myStack.Contains('{'))
                        return false;
                    else if (c == ']' && !myStack.Contains('['))
                        return false;
                    
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if(i < s.Length / 2)
                    {
                        if (myList.Contains($"{s[i]}{s[(s.Length - 1) - i]}") == false)
                            return false;
                    }
                }
                return true;
            }
        }
    }
}