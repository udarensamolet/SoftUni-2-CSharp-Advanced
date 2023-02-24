using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split('-', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> examSubmissions = new Dictionary<string, int>();
            Dictionary<string, int> studentsPoints = new Dictionary<string, int>();

            while (true)
            {
                if (input[0] == "exam finished")
                {
                    break;
                }

                if (input.Length == 3)
                {
                    string username = input[0];
                    string language = input[1];
                    int points = Convert.ToInt32(input[2]);


                    if (!studentsPoints.ContainsKey(username))
                    {
                        studentsPoints.Add(username, points);
                        if (!examSubmissions.ContainsKey(language))
                        {
                            examSubmissions.Add(language, 1);
                        }
                        else
                        {
                            examSubmissions[language]++;
                        }
                    }
                    else
                    {
                        if (studentsPoints[username] < points)
                        {
                            studentsPoints[username] = points;
                        }

                        if (!examSubmissions.ContainsKey(language))
                        {
                            examSubmissions.Add(language, 1);
                        }
                        else
                        {
                            examSubmissions[language]++;
                        }
                    }
                }
                else if (input.Length == 2)
                {
                    string usernameRemove = input[0];
                    if (studentsPoints.ContainsKey(usernameRemove))
                    {
                        studentsPoints.Remove(usernameRemove);
                    }
                }
                input = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            Console.WriteLine("Results:");
            foreach (var student in studentsPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var exam in examSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{exam.Key} - {exam.Value}");
            }
        }
    }
}
