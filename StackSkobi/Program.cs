namespace StackSkobi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (BalancedBrackets(input))
            {
                Console.WriteLine("Balanced");
            }
            else
            {
                Console.WriteLine("Not Balanced");
            }
        }
        static bool BalancedBrackets(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char ch in input)
            {
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    { 
                        return false; 
                    }
                    if (stack.Pop() != '(')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

