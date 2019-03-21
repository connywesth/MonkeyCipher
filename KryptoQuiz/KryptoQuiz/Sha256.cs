using System;
using System.Text;
using System.Security.Cryptography;

namespace Kodapor.KryptoQuiz
{
    class Sha256
    {
        public static string HexComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256 
            byte[] bytes;
            string hash = "";
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                hash = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData)).ToString();

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                hash = builder.ToString();
            }
            return hash;
        }
    }
}
