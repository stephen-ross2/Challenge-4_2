using System.Net.Security;

namespace Assignment_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();

            string[] input = ["a", "b", "c", "a", "c"];

            foreach (string s in input)
            {
                if (!count.TryAdd(s, 1))
                {
                    count[s]++;
                }
            }

            foreach (var kvp in count)
            {
                Console.WriteLine($"{kvp.Key}; {kvp.Value}");

            }
        }
    }
}
