using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsTasks_Lab3
{
    class StringEncryptor
    {
        private static string alphabet = "abcdefghijklmnopqrstuvwxyz ";
        private static string encryptedAlphabet = "efghijklmnopqrstuvwxyzabcd ";

        public static string Encrypt(string str)
        {
            string result = "";

            for(int i = 0; i < str.Length; i++)
            {
                var x = str[i];
                int index = alphabet.IndexOf(char.ToLower(x));
                result += encryptedAlphabet[index].ToString();
            }

            return result;
        }

        public static string Decrypt(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                var x = str[i];
                int index = encryptedAlphabet.IndexOf(char.ToLower(x));
                result += alphabet[index].ToString();
            }

            return result;
        }
    }
}
