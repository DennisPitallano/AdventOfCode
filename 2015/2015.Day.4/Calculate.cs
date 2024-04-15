using System.Text;
using System.Security.Cryptography;
namespace _2015.Day._4
{
    public static class Calculate
    {
        public static int FindLowestNumber(string input,string prefix ="00000")
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
