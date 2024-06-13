using System.Security.Cryptography;
using System.Text;

namespace MarketsIQ.Services.Quantower.API.Client.Business.Http
{
    internal class HeaderDataEncryptor
    {
        private const string KEY = "fk%3b*haUH7&mCbanso8b%@tfYYbt5LLx#Tz9Zrs";

        public static string Encrypt(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            string result;
            using (Aes aes = Aes.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes("fk%3b*haUH7&mCbanso8b%@tfYYbt5LLx#Tz9Zrs");
                int count = Math.Min(aes.IV.Length, bytes.Length);
                byte[] array = new byte[aes.IV.Length];
                Buffer.BlockCopy(bytes, 0, array, 0, count);
                using ICryptoTransform transform = aes.CreateEncryptor(array, aes.IV);
                using MemoryStream memoryStream = new MemoryStream();
                using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
                {
                    using StreamWriter streamWriter = new StreamWriter(stream);
                    streamWriter.Write(input);
                }

                byte[] iV = aes.IV;
                byte[] array2 = memoryStream.ToArray();
                byte[] array3 = new byte[iV.Length + array2.Length];
                Buffer.BlockCopy(iV, 0, array3, 0, iV.Length);
                Buffer.BlockCopy(array2, 0, array3, iV.Length, array2.Length);
                result = Convert.ToBase64String(array3);
            }

            return result;
        }

        public static string Decrypt(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            byte[] array = Convert.FromBase64String(input);
            string result;
            using (Aes aes = Aes.Create())
            {
                byte[] array2 = new byte[aes.IV.Length];
                byte[] array3 = new byte[array.Length - array2.Length];
                Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
                Buffer.BlockCopy(array, array2.Length, array3, 0, array.Length - array2.Length);
                byte[] bytes = Encoding.UTF8.GetBytes("fk%3b*haUH7&mCbanso8b%@tfYYbt5LLx#Tz9Zrs");
                int count = Math.Min(aes.IV.Length, bytes.Length);
                byte[] array4 = new byte[aes.IV.Length];
                Buffer.BlockCopy(bytes, 0, array4, 0, count);
                using ICryptoTransform transform = aes.CreateDecryptor(array4, array2);
                using MemoryStream stream = new MemoryStream(array3);
                using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
                using StreamReader streamReader = new StreamReader(stream2);
                result = streamReader.ReadToEnd();
            }

            return result;
        }
    }
}
