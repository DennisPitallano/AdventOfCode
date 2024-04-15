namespace _2015.Day._3
{
    public static class Calculate
    {
        ///<summary>
        ///Calculates the number of houses that receive at least one present.
        ///</summary>
        ///<param name="directions">The directions to calculate the number of houses that receive at least one present.</param>
        ///<returns>The number of houses that receive at least one present.</returns>
        public static int Houses(string directions)
        {
            var visited = new HashSet<(int, int)>();
            var x = 0;
            var y = 0;

            visited.Add((x, y));

            foreach (var direction in directions)
            {
                switch (direction)
                {
                    case '^':
                        y++;
                        break;
                    case 'v':
                        y--;
                        break;
                    case '>':
                        x++;
                        break;
                    case '<':
                        x--;
                        break;
                    default:
                        throw new ArgumentException("Invalid direction.");
                }

                visited.Add((x, y));
            }

            return visited.Count;
        }

        /// <summary>
        /// Calculates the number of houses that receive at least one present.
        /// </summary>
        /// <param name="directions">The directions to calculate the number of houses that receive at least one present.</param>
        /// <param name="santaCount">The number of Santas delivering presents.</param>
        /// <returns>The number of houses that receive at least one present.</returns>
        public static int Houses(string directions, int santaCount)
        {
            var visited = new HashSet<(int, int)>();
            var santas = new (int, int)[santaCount];
            for (var i = 0; i < santaCount; i++)
            {
                santas[i] = (0, 0);
                visited.Add(santas[i]);
            }

            var santaIndex = 0;

            foreach (var direction in directions)
            {
                switch (direction)
                {
                    case '^':
                        santas[santaIndex].Item2++;
                        break;
                    case 'v':
                        santas[santaIndex].Item2--;
                        break;
                    case '>':
                        santas[santaIndex].Item1++;
                        break;
                    case '<':
                        santas[santaIndex].Item1--;
                        break;
                    default:
                        throw new ArgumentException("Invalid direction.");
                }

                visited.Add(santas[santaIndex]);

                santaIndex = (santaIndex + 1) % santaCount;
            }

            return visited.Count;
        }
    }
}
