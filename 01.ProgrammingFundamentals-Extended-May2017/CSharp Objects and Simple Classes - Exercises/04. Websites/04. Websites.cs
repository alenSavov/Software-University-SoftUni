using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Websites
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }

        public Websites(string host, string domain, List<string> queries)
        {
            this.Host = host;
            this.Domain = domain;
            this.Queries = queries;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Websites> websites = new List<Websites>();

            List<string> input = Console.ReadLine()
                .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (input[0] != "end")
            {
                string host = input[0];
                string domain = input[1];
                List<string> queries;
                if (input.Count > 2)
                {
                    queries = input[2].Split(',').ToList();
                }
                else
                {
                    queries = new List<string>();
                }

                websites.Add(new Websites(host, domain, queries));                

                input = Console.ReadLine()
                                .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                                .ToList();
            }

            foreach (var website in websites)
            {
                Console.Write("https://www.{0}.{1}",
                    website.Host,website.Domain);
                if (website.Queries.Count > 0)
                {
                    Console.Write("/query?=[{0}]",string.Join("]&[",website.Queries));
                }
                Console.WriteLine();
            }

        }
    }
}
