using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text.RegularExpressions;

using System.Security.Cryptography.X509Certificates;

namespace EP03.TheAngryCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int entryPoint = int.Parse(Console.ReadLine());
            int startIndexRight = targets[entryPoint];
            int startIndexLeft = targets[entryPoint];


            int rightSum = 0;
            int leftSum = 0;

            string itemType = Console.ReadLine();
            List<int> resultLeft = new List<int>();
            List<int> resultRight = new List<int>();

            for (int i = entryPoint + 1; i < targets.Count; i++)
            {
                if (itemType == "cheap")
                {
                    if (targets[i] < targets[entryPoint])
                    {
                        resultRight.Add(targets[i]);
                        rightSum = resultRight.Sum();
                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    if (targets[i] >= targets[entryPoint])
                    {
                        resultRight.Add(targets[i]);
                        rightSum = resultRight.Sum();
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            for (int i = entryPoint - 1; i >= 0; i--)
            {
                if (itemType == "cheap")
                {
                    if (targets[i] < targets[entryPoint])
                    {
                        resultLeft.Add(targets[i]);
                        leftSum = resultLeft.Sum();
                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    if (targets[i] >= targets[entryPoint])
                    {
                        resultLeft.Add(targets[i]);
                        leftSum = resultLeft.Sum();
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }

        }
    }
}
