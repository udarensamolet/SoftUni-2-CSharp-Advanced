using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main()
        {
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (!symbols.ContainsKey(input[i]))
                {
                    symbols.Add(input[i], 1);
                }
                else
                {
                    symbols[input[i]]++;
                }
            }

            foreach(var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        } 
    }
}
