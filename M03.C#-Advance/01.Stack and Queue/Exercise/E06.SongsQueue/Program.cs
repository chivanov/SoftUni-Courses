using System;
using System.Collections.Generic;

namespace E06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queue = new Queue<string>(songs);
            while (queue.Count > 0)
            {
                string input = Console.ReadLine();
                if (input == "Play")
                {
                    queue.Dequeue();
                }
                else if (input == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else
                {
                    //string[] cmdInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    //Queue<string> currSong = new Queue<string>(cmdInfo);

                    //currSong.Dequeue();

                    //string song = string.Join(" ", currSong);
                    string song = input.Substring(4);   
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }

                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
