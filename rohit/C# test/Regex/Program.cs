using System;
using System.Text.RegularExpressions;
namespace regex
{
    class program
    {
        public static void main()
        {
            var words = new List<string>() { "Rohit", "mohit","dan" };

            var rx = new Regex(@".dan", RegexOptions.Compiled);

            foreach (string word in words)
            {
                if (rx.IsMatch(word))
                {
                    Console.WriteLine($"{word}  = MATCHED");
                }
                else
                {
                    Console.WriteLine($"{word} Does Not Matched");
                }
            }
        }
    }
}

