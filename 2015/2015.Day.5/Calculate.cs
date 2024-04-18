namespace _2015.Day._5
{
    internal static class Calculate
    {

        /// <summary>
        /// Counts the number of nice strings in the input.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The count of nice strings.</returns>
        public static int CountNice(string input)
        {
            var count = 0;
            foreach (var line in input.Split('\n'))
            {
                if (IsNice(line))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Counts the number of nice strings in the input.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The count of nice strings.</returns>
        public static int CountNice2(string input)
        {
            var count = 0;
            foreach (var line in input.Split('\n'))
            {
                if (IsNice2(line))
                {
                    count++;
                }
            }
            return count;
        }


        /// <summary>
        /// Determines whether the input string is a nice string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns><c>true</c> if the input string is a nice string; otherwise, <c>false</c>.</returns>
        public static bool IsNice(string input)
        {
            return HasThreeVowels(input) && HasDoubleLetter(input) && !HasForbiddenStrings(input);
        }

        /// <summary>
        /// Determines whether the input string is a nice string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns><c>true</c> if the input string is a nice string; otherwise, <c>false</c>.</returns>
        public static bool IsNice2(string input)
        {
            return HasPairOfLetters(input) && HasRepeatingLetter(input);
        }

        /// <summary>
        /// Determines whether the input string has at least three vowels.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns><c>true</c> if the input string has at least three vowels; otherwise, <c>false</c>.</returns>
        private static bool HasThreeVowels(string input)
        {
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            var count = 0;
            foreach (var c in input)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count >= 3;
        }

        /// <summary>
        /// Determines whether the input string has a double letter.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns><c>true</c> if the input string has a double letter; otherwise, <c>false</c>.</returns>
        private static bool HasDoubleLetter(string input)
        {
            for (var i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether the input string has any forbidden strings.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns><c>true</c> if the input string has any forbidden strings; otherwise, <c>false</c>.</returns>
        private static bool HasForbiddenStrings(string input)
        {
            var forbidden = new[] { "ab", "cd", "pq", "xy" };
            foreach (var s in forbidden)
            {
                if (input.Contains(s))
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Determines whether the input string has a pair of letters.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns><c>true</c> if the input string has a pair of letters; otherwise, <c>false</c>.</returns>
        private static bool HasPairOfLetters(string input)
        {
            for (var i = 0; i < input.Length - 1; i++)
            {
                var pair = $"{input[i]}{input[i + 1]}";
                if (input.Substring(i + 2).Contains(pair))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether the input string has a repeating letter.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns><c>true</c> if the input string has a repeating letter; otherwise, <c>false</c>.</returns>
        private static bool HasRepeatingLetter(string input)
        {
            for (var i = 0; i < input.Length - 2; i++)
            {
                if (input[i] == input[i + 2])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
