using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regexx
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var text = Console.ReadLine();

            var keyPattern = (@"^(?<startKey>[a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(?<endKey>[a-zA-Z]*)");
            var keyMatch = Regex.Match(key , keyPattern);

            if (keyMatch.Success)
            {
                var startKey = keyMatch.Groups["startKey"].Value;
                var endKey = keyMatch.Groups["end"].Value;

                var textPatter = $@"{startKey}(?<endKey>.*?){endKey}";
                var matches = Regex.Matches(text, textPatter);

                var result = new StringBuilder();

                foreach (Match match in matches)
                {
                    result.Append(match.Groups["word"].Value);
                }

                Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
            }
        }
    }
}
