using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Commits

{
    class GithubUsers
    {
        public GithubUsers(string name, string commiteHash, string message, int additionsCount, int deletionsCount)
        {
            this.CommiteHash = commiteHash;
            this.Message = message;
            this.AdditionCounts = additionsCount;
            this.DeletionCounts = deletionsCount;
            this.Name = name;
        }
        public string Name { get; set; }

        public string CommiteHash { get; set; }

        public string Message { get; set; }

        public int AdditionCounts { get; set; }

        public int DeletionCounts { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"https:\/\/github.com\/(?<name>[a-zA-Z0-9]+[-]?)\/(?<repo>[a-z]+[-_a-z]+)\/commit\/(?<hash>[0-9a-f]{40})");
            var githubRegex = regex.Matches(input);

            

            while (input != "git push")
            {
                var inputTokens = input.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var commiteMessage = inputTokens[1];
                var additionsCount = int.Parse(inputTokens[2]);
                var delitionsCount = int.Parse(inputTokens[3]);

                foreach (Match user in githubRegex)
                {                  
                    var gitHubUser = new GithubUsers(user.Groups["name"].Value, user.Groups["hash"].Value, commiteMessage, additionsCount, delitionsCount);
                    var name = user.Groups["name"].Value;

                    input = Console.ReadLine();
                }
            }
        }
    }
}
