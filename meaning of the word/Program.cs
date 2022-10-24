using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meaning_of_the_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            bool isFound = false;

            words.Add("первое слово", "первое значение");
            words.Add("второе слово", "второе значение");
            words.Add("третье слово", "третье значение");

            string input = Console.ReadLine();

            foreach(var word in words)
            {
                if(word.Key == input)
                {
                    isFound = true;
                    Console.WriteLine($"{word.Key} - {word.Value}");
                }
            }

            if(isFound == false)
            {
                Console.WriteLine("слово не найдено");
            }
        }
    }
}
