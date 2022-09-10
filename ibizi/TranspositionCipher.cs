using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class TranspositionCipher
    {
        public static string Encrypt(string data, byte[] horizontalKey, byte[] verticalKey)
        {
            if (data.Length > horizontalKey.Length * verticalKey.Length)
                throw new Exception("key is too short");
            /*for (int i = 0; i < horizontalKey.Length; i++)
                horizontalKey[i] -= 1;
            for(int i = 0; i < verticalKey.Length; i++)
                verticalKey[i] -= 1;*/
            StringBuilder encryptedData = new StringBuilder(data);
            for (int i = 0; i < encryptedData.Length; i++)
            {
                encryptedData[verticalKey[i % verticalKey.Length] * verticalKey.Length + horizontalKey[i / horizontalKey.Length]] = data[i];
            }
            return encryptedData.ToString();
        }
    }
}
