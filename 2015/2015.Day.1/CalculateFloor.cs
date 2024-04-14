using System.Drawing;

namespace _2015.Day._1
{
    public static class CalculateFloor
    {
        /// <summary>
        /// Calculates the floor Santa ends up on based on the given instructions.
        /// </summary>
        /// <param name="instructions">The instructions representing the movements of Santa.</param>
        /// <returns>The floor Santa ends up on.</returns>
        public static int Calculate(string instructions)
        {
            var floor = 0;
            for (var i = instructions.Length - 1; i >= 0; i--)
            {
                var c = instructions[i];
                floor = Floor(c, floor);
            }
            return floor;
        }

        /// <summary>
        /// Finds the position of the first instruction that causes Santa to enter the basement.
        /// </summary>
        /// <param name="instructions">The instructions representing the movements of Santa.</param>
        /// <returns>The position of the first instruction that causes Santa to enter the basement. Returns -1 if Santa never enters the basement.</returns>
        public static int FindBasementPosition(string instructions)
        {
            var floor = 0;
            var position = 0;

            foreach (var t in instructions)
            {
                position++;

                floor = Floor(t, floor);

                if (floor == -1)
                {
                    return position;
                }
            }

            return -1; // Santa never enters the basement
        }

        /// <summary>
        /// Calculates the floor based on the given instruction and current floor.
        /// </summary>
        /// <param name="instruction">The instruction representing the movement of Santa.</param>
        /// <param name="currentFloor">The current floor Santa is on.</param>
        /// <returns>The updated floor after applying the instruction.</returns>
        private static int Floor(char instruction, int currentFloor)
        {
    
            return instruction switch
            {
                '(' => currentFloor + 1,
                ')' => currentFloor - 1,
                _ => currentFloor
            };
           
        }
    }
}
