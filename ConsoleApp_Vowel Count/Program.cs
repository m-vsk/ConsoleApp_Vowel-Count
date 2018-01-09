using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Vowel_Count
{
    public static class Kata
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            vowelCount = str.ToLower().Count(c => vowels.Contains(c));
            return vowelCount;// = str.Count(c => c == 'a');
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter:");
            string sentence = Console.ReadLine().ToLower();
            Console.WriteLine(Kata.GetVowelCount(sentence));
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
