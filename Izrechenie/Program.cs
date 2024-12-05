namespace Izrechenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().Split(" ").ToArray();
            Stack<string> words = new Stack<string>();
            for (int i = 0; i < sentence.Length; i++)
            {
                words.Push(sentence[i]);
            }
            Console.WriteLine($"Words in sentence:{words.Count}");
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
