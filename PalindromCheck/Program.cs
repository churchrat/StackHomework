namespace PalindromCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Stack<char> chars = new Stack<char>();
            for (int i = 0; i < word.Length;i++)
            {               
                chars.Push(word[i]);
            }
            if (IsPalindrom(chars, word))
            {
                Console.WriteLine("It is a Palindrom");
            }
            else
            {
                Console.WriteLine("It is not a Palindrom");
            }
        }
        static bool IsPalindrom(Stack<char> chars, string word)
        {
            for (int i = 0;i < word.Length; i++)
            {
                if (word[i] != chars.Pop())
                {
                    return false;
                }
            } 
            return true;
        }
    }
}
