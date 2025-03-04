using System.Security.Cryptography;
using System.Text;

namespace DrogeriaProjekt.Utils
{
    public static class Security
    {
        public static string Hash(string text, Encoding encoding)
        {
            string hash = string.Empty;

            using (var sha256 = SHA256.Create())
            {
                var bytes = encoding.GetBytes(text);
                hash = Convert.ToBase64String(sha256.ComputeHash(bytes));
            }

            return hash;
        }
    }

}
