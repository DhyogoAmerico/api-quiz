using System.Security.Cryptography;
using System.Text;

namespace Quiz.Domain.ValueType
{
    public struct Password
    {
        // private static string Salt => "zyd4ztBj2LedC5nkAlpF1D6v9";
        private readonly string Hash;

        public Password(string hash)
        {
            Hash = hash;
        }

        public static implicit operator string(Password password) => password.Hash;
        public static implicit operator Password(string email) => new (email);

        public string ToMD5()
        {
            var saltByte = Encoding.UTF8.GetBytes("zyd4ztBj2LedC5nkAlpF1D6v9");
            var hmacMD5 = new HMACMD5(saltByte);
            var password = Encoding.UTF8.GetBytes(Hash!);
            return Convert.ToBase64String(hmacMD5.ComputeHash(password));
        }
    }
}