using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParty
{
    class SoftUniParty
    {
        static void Main()
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string input = Console.ReadLine();
            while (input != "PARTY" && input != "END")
            {
                if (input != "PARTY" && input != "END")
                {
                    char firstChar = input[0];
                    if (firstChar >= '0' && firstChar <= '9')
                    {
                        vipGuests.Add(input);
                    }
                    else
                    {
                        regularGuests.Add(input);
                    }
                }
                input = Console.ReadLine();
            }

            if (input == "PARTY")
            {
                while (true)
                {
                    string attendingGuest = Console.ReadLine();

                    if (attendingGuest == "END")
                    {
                        break;
                    }

                    if (vipGuests.Contains(attendingGuest))
                    {
                        vipGuests.Remove(attendingGuest);
                    }
                    else if (regularGuests.Contains(attendingGuest))
                    {
                        regularGuests.Remove(attendingGuest);
                    }
                }
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            foreach (var vip in vipGuests)
            {
                Console.WriteLine(vip);
            }
            foreach (var regular in regularGuests)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
