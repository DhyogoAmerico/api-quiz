using System.Security.Cryptography;
using System.Text;

namespace Quiz.Domain.ValueType
{
    public class Password
    {
        private static string Salt => "zyd4ztBj2LedC5nkAlpF1D6v9";
        public string? Hash { get; set; }

        public Password(string? hash)
        {
            Hash = hash;
        }

        public static implicit operator string(Password password) => password.Hash ?? string.Empty;
        public static implicit operator Password(string email) => email;

        public string ToMD5()
        {
            var saltByte = Encoding.UTF8.GetBytes(Salt!);
            var hmacMD5 = new HMACMD5(saltByte);
            var password = Encoding.UTF8.GetBytes(Hash!);
            return hmacMD5.ComputeHash(password).ToString()!;
        }
    }
}