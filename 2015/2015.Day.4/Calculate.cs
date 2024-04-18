using System.Text;
using System.Security.Cryptography;
namespace _2015.Day._4
{
    public static class Calculate
    {
        /// <summary>
        /// Finds the lowest number that, when appended to the input string, produces an MD5 hash that starts with the specified prefix.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="prefix">The prefix that the MD5 hash should start with. Default is "00000".</param>
        /// <returns>The lowest number that satisfies the condition.</returns>
        public static int FindLowestNumber(string input, string prefix = "00000")
        {
            var number = 0;
            while (true)
            {
                var hash = CalculateMd5Hash(input + number);
                if (hash.StartsWith(prefix))
                {
                    break;
                }
                number++;
            }
            return number;
        }

        /// <summary>
        /// Calculates the MD5 hash of the input string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The MD5 hash of the input string.</returns>
        private static string CalculateMd5Hash(string input)
        {
            using var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hashBytes = md5.ComputeHash(inputBytes);
            var sb = new StringBuilder();
            for (var i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
