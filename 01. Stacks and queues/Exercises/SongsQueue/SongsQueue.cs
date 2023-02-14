using System;
using System.Linq;
using System.Collections.Generic;

namespace SongsQueue
{
    class SongsQueue
    {
        static void Main()
        {
            string[] songsInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> songs = new Queue<string>();

            for (int i = 0; i < songsInput.Length; i++)
            {
                if (!songs.Contains(songsInput[i]))
                {
                    songs.Enqueue(songsInput[i]);
                }
            }

            while (songs.Count > 0)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = tokens[0];

                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {
                    string song = null;
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        if (i != tokens.Length - 1)
                        {
                            song = song + tokens[i] + " ";
                        }
                        else
                        {
                            song = song + tokens[i];
                        }
                    }
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    string[] queuedSongs = songs.ToArray();
                    Console.WriteLine(string.Join(", ", queuedSongs));
                }
            }
            Console.WriteLine("No more songs!");

        } 
    }
}
