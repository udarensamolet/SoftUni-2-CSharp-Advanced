using System;
using System.Linq;
using System.Collections.Generic;

namespace ForceBook
{
    class ForceBook
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            string token = null;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '|' && inputString[i + 1] == ' ')
                {
                    token = "|";
                    break;
                }
                else if (inputString[i] == '-' && inputString[i + 1] == '>')
                {
                    token = "->";
                    break;
                }
            }

            string[] input = inputString
                .Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();

            while (true)
            {
                if (input[0] == "Lumpawaroo")
                {
                    break;
                }

                if (token == "|")
                {
                    string forceSide = input[0];
                    string forceUser = input[1];

                    bool isContained = false;
                    foreach (var side in forceSides)
                    {
                        if (!side.Value.Contains(forceUser))
                        {
                            isContained = false;
                        }
                        else
                        {
                            isContained = true;
                            break;
                        }
                    }

                    if (!isContained)
                    {
                        if (forceSides.ContainsKey(forceSide))
                        {
                            forceSides[forceSide].Add(forceUser);
                        }
                        else
                        {
                            forceSides.Add(forceSide, new List<string>());
                            forceSides[forceSide].Add(forceUser);
                        }
                    }
                }

                else if (token == "->")
                {
                    string forceUser = input[0];
                    string newForceSide = input[1];

                    bool isContained = false;
                    foreach (var side in forceSides)
                    {
                        if (!side.Value.Contains(forceUser))
                        {
                            isContained = false;
                        }
                        else
                        {
                            isContained = true;
                            break;
                        }
                    }

                    string oldForceSide = forceSides.FirstOrDefault(x => x.Value.Contains(forceUser)).Key;

                    if (!isContained)
                    {
                        if (forceSides.ContainsKey(newForceSide))
                        {
                            forceSides[newForceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {newForceSide} side!");
                        }
                        else
                        {
                            forceSides.Add(newForceSide, new List<string>());
                            forceSides[newForceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {newForceSide} side!");
                        }
                    }
                    else
                    {
                        if (forceSides.ContainsKey(newForceSide))
                        {
                            if (oldForceSide != newForceSide)
                            {
                                forceSides[oldForceSide].Remove(forceUser);
                                forceSides[newForceSide].Add(forceUser);
                                Console.WriteLine($"{forceUser} joins the {newForceSide} side!");
                            }
                        }
                        else
                        {
                            if (oldForceSide != newForceSide)
                            {
                                forceSides[oldForceSide].Remove(forceUser);
                                forceSides.Add(newForceSide, new List<string>());
                                forceSides[newForceSide].Add(forceUser);
                                Console.WriteLine($"{forceUser} joins the {newForceSide} side!");
                            }
                        }
                    }
                }

                inputString = Console.ReadLine();
                token = null;
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString[i] == '|' && inputString[i + 1] == ' ')
                    {
                        token = "|";
                        break;
                    }
                    else if (inputString[i] == '-' && inputString[i + 1] == '>')
                    {
                        token = "->";
                        break;
                    }
                }

                input = inputString
                    .Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            foreach (var side in forceSides.Where(side => side.Value.Count >= 1).OrderByDescending(side => side.Value.Count).ThenBy(side => side.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(user => user))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
