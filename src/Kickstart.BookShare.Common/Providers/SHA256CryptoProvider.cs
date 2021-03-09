using System;
using System.Security.Cryptography;
using System.Text;

namespace Kickstart.BookShare.Common.Providers
{
    public class SHA256CryptoProvider : CryptoProvider
    {
        public override string GetHash(string input)
        {
            using HashAlgorithm hashAlgorithm = SHA256.Create();
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            return ByteArrayToString(data);
        }

        public override bool VerifyHash(string input, string hash)
        {
            using HashAlgorithm hashAlgorithm = SHA256.Create();
            var hashOfInput = GetHash(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}
