using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1123
{
    public static class Security
    {
        public static string sHA256_EnCrypt(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sHA256ManagedString = new SHA256Managed();
            byte[] hash = sHA256ManagedString.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static bool CheckEncrypt(string plainTextInput, string hashedInput, string salt)
        {
            string newHashedPin = sHA256_EnCrypt(plainTextInput, salt);
            return newHashedPin.Equals(hashedInput);
        }
    }
}
