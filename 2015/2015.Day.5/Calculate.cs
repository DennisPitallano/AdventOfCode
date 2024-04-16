namespace _2015.Day._5
{
    internal static class Calculate
    {

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

        public static bool IsNice(string input)
        {
            return HasThreeVowels(input) && HasDoubleLetter(input) && !HasForbiddenStrings(input);
        }

        public static bool IsNice2(string input)
        {
            return HasPairOfLetters(input) && HasRepeatingLetter(input);
        }

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
