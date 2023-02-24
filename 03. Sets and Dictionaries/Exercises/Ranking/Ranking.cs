using System;
using System.Linq;
using System.Collections.Generic;

namespace Ranking
{
    class Ranking
    {
        static void Main()
        {
            Dictionary<string, string> contestPasswords = new Dictionary<string, string>();
            while (true)
            {
                string[] input = Console.ReadLine()
                     .Split(':', StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
                if (input[0] == "end of contests")
                {
                    break;
                }
                string contestName = input[0];
                string contestPassword = input[1];
                if (!contestPasswords.ContainsKey(contestName))
                {
                    contestPasswords.Add(contestName, contestPassword);
                }
            }

            Dictionary<string, Dictionary<string, int>> usersContestsPoints = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (input[0] == "end of submissions")
                {
                    break;
                }

                string contestName = input[0];
                string contestPassword = input[1];
                string username = input[2];
                int points = Convert.ToInt32(input[3]);

                if (contestPasswords.ContainsKey(contestName) && contestPasswords[contestName] == contestPassword)
                {
                    if (!usersContestsPoints.ContainsKey(username))
                    {
                        usersContestsPoints.Add(username, new Dictionary<string, int>());
                        usersContestsPoints[username].Add(contestName, points);
                    }
                    else
                    {
                        if (!usersContestsPoints[username].ContainsKey(contestName))
                        {
                            usersContestsPoints[username].Add(contestName, points);
                        }
                        else
                        {
                            if (points > usersContestsPoints[username][contestName])
                            {
                                usersContestsPoints[username][contestName] = points;
                            }
                        }
                    }
                }
            }

            Dictionary<string, int> bestCandidate = new Dictionary<string, int>();
            int bestPoints = int.MinValue;
            string bestUser = null;
            foreach (var user in usersContestsPoints)
            {
                int userPoints = 0;
                foreach (var contest in user.Value)
                {
                    userPoints += contest.Value;
                }
                if (userPoints > bestPoints)
                {
                    bestPoints = userPoints;
                    bestUser = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (var user in usersContestsPoints.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");
                foreach (var contest in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
