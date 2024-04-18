using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015.Day._6
{
    internal static class Calculate
    {
        /// <summary>
        /// Calculates the number of lights that are turned on after following the instructions in the input.
        /// </summary>
        /// <param name="input">The array of instructions.</param>
        /// <returns>The number of lights that are turned on.</returns>
        public static int Part1(string[] input)
        {
            var grid = new bool[1000, 1000];
            foreach (var line in input)
            {
                var parts = line.Split(' ');
                if (parts[0] == "turn")
                {
                    var start = parts[2].Split(',').Select(int.Parse).ToArray();
                    var end = parts[4].Split(',').Select(int.Parse).ToArray();
                    for (var i = start[0]; i <= end[0]; i++)
                    {
                        for (var j = start[1]; j <= end[1]; j++)
                        {
                            grid[i, j] = parts[1] == "on";
                        }
                    }
                }
                else
                {
                    var start = parts[1].Split(',').Select(int.Parse).ToArray();
                    var end = parts[3].Split(',').Select(int.Parse).ToArray();
                    for (var i = start[0]; i <= end[0]; i++)
                    {
                        for (var j = start[1]; j <= end[1]; j++)
                        {
                            grid[i, j] = !grid[i, j];
                        }
                    }
                }
            }
            return grid.Cast<bool>().Count(b => b);
        }
    }
}
