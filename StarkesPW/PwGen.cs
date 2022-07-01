using System;
using System.Security.Cryptography;

namespace StarkesPW
{
    class PwGen
    {
        public string GenPW(int length)
        {
            using (RNGCryptoServiceProvider cryptPW = new RNGCryptoServiceProvider())
            {
                byte[] pwBuffer = new byte[length];
                cryptPW.GetBytes(pwBuffer);
                return Convert.ToBase64String(pwBuffer);
            }
        }

    }
}
