using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> inputValues = new Dictionary<string, int>();
            string[] tokens = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "end")
            {
                string keyInput = tokens[0];
                string valueInput = tokens[1];

                int numberValue;
                if (int.TryParse(valueInput, out numberValue))
                {
                    inputValues[keyInput] = numberValue;
                }
                else
                {
                    if (inputValues.ContainsKey(valueInput))
                    {
                        inputValues[keyInput] = inputValues[valueInput];
                    }
                }

                tokens = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in inputValues)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}