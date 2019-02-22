using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Travel_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var travelCompanyOffers = new Dictionary<string, Dictionary<string, int>>();

            while (input != "ready")
            {
                string[] packages = input.Split(':');
                string cityes = packages[0];
                string[] venchiesAndCapacyti = packages[1].Split("-,".ToCharArray());


                List<string> vechine = new List<string>();
                List<int> capacyti = new List<int>();


                SplitTheVechinesAndCapacyti(venchiesAndCapacyti, vechine, capacyti);

                if (!travelCompanyOffers.ContainsKey(cityes))
                {
                    travelCompanyOffers[cityes] = new Dictionary<string, int>();
                }

                for (int i = 0; i < capacyti.Count; i++)
                {
                    if (!travelCompanyOffers[cityes].ContainsKey(vechine[i]))
                    {
                        travelCompanyOffers[cityes][vechine[i]] = 0;
                    }
                    travelCompanyOffers[cityes][vechine[i]] = capacyti[i];
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();



            while (input != "travel time!")
            {
                string[] group = input.Split(' ');
                string citye = group[0];
                int peopleCount = int.Parse(group[1]);

                foreach (var city in travelCompanyOffers)
                {
                    int sum = 0;
                    if (city.Key == citye)
                    {
                        foreach (var places in city.Value)
                        {
                            sum += places.Value;
                        }

                        if (sum >= peopleCount)
                        {
                            Console.WriteLine($"{city.Key} -> all {peopleCount} accommodated");
                        }
                        else
                        {
                            Console.WriteLine(($"{city.Key} -> all except {peopleCount - sum} accommodated"));
                        }
                    }

                }
                input = Console.ReadLine();
            }
        }

        private static void SplitTheVechinesAndCapacyti(string[] venchiesAndCapacyti, List<string> vechine, List<int> capacyti)
        {
            for (int i = 0; i < venchiesAndCapacyti.Length; i++)
            {
                if (i % 2 == 0)
                {
                    vechine.Add(venchiesAndCapacyti[i]);
                }
                if (i % 2 != 0)
                {
                    capacyti.Add(int.Parse(venchiesAndCapacyti[i]));
                }

            }


        }
    }
}
