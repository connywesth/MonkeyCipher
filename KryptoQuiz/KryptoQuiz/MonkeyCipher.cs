using System;
using System.Collections.Generic;
using System.Text;

namespace Kodapor.KryptoQuiz
{
    public class MonkeyCipher
    {
        public static string EnCrypt(int key, string clearString)
        {
            int pos = 0;
            int value = 0;
            string cryptedText = "";
            foreach (char ch in clearString)
            {
                value = ((int)ch) + key + pos;
                cryptedText += $"{(char)(value)}";
                pos++;
            }
            return cryptedText;
        }

        public static string DeCrypt(int key, string cryptedString)
        {
            int pos = 0;
            int value = 0;
            string deCryptedText = "";
            foreach (char ch in cryptedString)
            {
                value = ((int)ch) - key - pos;
                deCryptedText += $"{(char)value}";
                pos++;
            }
            return deCryptedText;
        }
    }
}
