using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace FarmFreshApiService.Services
{
    public class SecurityService
    {    
        public static string DecryptDBCreds(string cipherText, string tagText, string vid, string routingNo, string associatedData)
        {
            byte[] virtualIDBytes = Encoding.UTF8.GetBytes(vid);
            byte[] associatedDataBytes = Encoding.UTF8.GetBytes(associatedData);
            byte[] routingNoBytes = Encoding.UTF8.GetBytes(routingNo);

            byte[] cipherForDecrypt = Convert.FromBase64String(cipherText);
            byte[] tagForDecrypt = Convert.FromBase64String(tagText);

            List<byte> key = new();
            List<byte> nonce = new();

            if (virtualIDBytes.Length < 32)
            {
                key = new List<byte>(virtualIDBytes);
                key = PadByteArray(virtualIDBytes, key, 32);
            }
            else
            {
                key = new List<byte>(virtualIDBytes);
            }

            if (routingNoBytes.Length < 12)
            {
                nonce = new List<byte>(routingNoBytes);
                nonce = PadByteArray(routingNoBytes, nonce, 12);
            }
            else
            {
                nonce = new List<byte>(routingNoBytes);
            }

            var decryptedValue = Decrypt(cipherForDecrypt, key.ToArray(), nonce.ToArray(), tagForDecrypt, associatedDataBytes);

            string plaintext = Encoding.UTF8.GetString(decryptedValue);

            return plaintext;

        }

        private static List<byte> PadByteArray(byte[] sourceByteArray, List<byte> targetByteList, int targetLength)
        {
            int i = 0;
            while (targetByteList.Count < targetLength)
            {
                if (i == sourceByteArray.Length)
                    i = 0;

                targetByteList.Add(sourceByteArray[i]);
                i++;
            }
            return targetByteList;
        }

        private static byte[] Decrypt(byte[] cipherText, byte[] key, byte[] nonce, byte[] tag, byte[] assocData)
        {
            byte[] plainText = new byte[cipherText.Length];

            using AesGcm aesGcm = new AesGcm(key);
            aesGcm.Decrypt(nonce, cipherText, tag, plainText, assocData);

            return plainText;
        }
    }
}
