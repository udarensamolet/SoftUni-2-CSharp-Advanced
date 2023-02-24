using System;
using System.Linq;
using System.Collections.Generic;

namespace TheVLogger
{
    class TheVlogger
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> vloggers = new Dictionary<string, Dictionary<string, List<string>>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistics")
                {
                    break;
                }
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = tokens[1];
                if (action == "joined")
                {
                    string vlogger = tokens[0];
                    if (!vloggers.ContainsKey(vlogger))
                    {
                        vloggers.Add(vlogger, new Dictionary<string, List<string>>());
                        vloggers[vlogger].Add("followers", new List<string>());
                        vloggers[vlogger].Add("following", new List<string>());
                    }
                }
                else if (action == "followed")
                {
                    string vlogger = tokens[2];
                    string follower = tokens[0];

                    if (vloggers.ContainsKey(vlogger) && vloggers.ContainsKey(follower))
                    {
                        if (vlogger != follower && !vloggers[vlogger]["followers"].Contains(follower)
                            && !vloggers[follower]["following"].Contains(vlogger))
                        {
                            vloggers[vlogger]["followers"].Add(follower);
                            vloggers[follower]["following"].Add(vlogger);
                        }
                    }
                }
            }

            int counter = 1;
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vloggers[vlogger.Key]["followers"].Count} followers, {vloggers[vlogger.Key]["following"].Count} following");
                if (counter == 1)
                {
                    foreach (var list in vlogger.Value)
                    {
                        if (list.Key == "followers")
                        {
                            foreach (var person in list.Value.OrderBy(z => z))
                            {
                                Console.WriteLine($"*  {person}");
                            }
                        }
                            
                    }
                }
                counter++;
            }
        }
    }
}
