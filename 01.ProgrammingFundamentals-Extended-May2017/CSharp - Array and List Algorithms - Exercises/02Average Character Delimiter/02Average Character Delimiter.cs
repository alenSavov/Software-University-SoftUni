using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ').ToList();

            double totalSum = 0;
            double countOfCharacters = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                string word = elements[i];
                countOfCharacters += word.Length;

                for (int j = 0; j < word.Length; j++)
                {
                    totalSum += word[j];

                }

            }
            char charDelimetar =(char) (int)(totalSum / countOfCharacters);
            string delimiter = charDelimetar.ToString().ToUpper();

            Console.WriteLine(string.Join(delimiter , elements));
        }
        
    }
}