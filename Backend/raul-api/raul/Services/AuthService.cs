using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace raul.Services
{
    public class AuthService
    {
        public byte[] getSalt ()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            return salt;
        }

        public byte[] getHash (string password, byte [] salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            return pbkdf2.GetBytes(20);
        }

        public byte[] getSaltAndHashCombined (byte[] salt, byte[] hash)
        {
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return hashBytes;
        }

        public string getSaltAndHashString (byte[] hashbytes)
        {
            string savedPasswordHash = Convert.ToBase64String(hashbytes);
            return savedPasswordHash;
        }
    }
}
