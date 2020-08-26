using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace raul.Services
{
    public class AuthService : GenericService
    {

        public bool login (string username, string password)
        {
            RaulUser persistedUser = dbContext.RaulUser.Where(u => u.Username == username).FirstOrDefault();

            if (persistedUser == null)
            {
                return false;
            }

            string hashedPass = getProcessedPassword(password);

            return false;
        }

        public bool register (string username, string password)
        {
            //Check if user exists 1st
            return false;
        }

        private bool isUserRegistered ()
        {

            return false;
        }

        private string getProcessedPassword (string password)
        {
            byte[] salt = this.getSalt();
            byte[] hash = this.getHash(password, salt);
            byte[] saltAndHash = this.getSaltAndHashCombined(salt, hash);
            string processedPass = this.getSaltAndHashString(saltAndHash);
            return processedPass;
        }
           
        private byte[] getSalt ()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            return salt;
        }

        private byte[] getHash (string password, byte [] salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            return pbkdf2.GetBytes(20);
        }

        private byte[] getSaltAndHashCombined (byte[] salt, byte[] hash)
        {
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return hashBytes;
        }

        private string getSaltAndHashString (byte[] hashbytes)
        {
            string savedPasswordHash = Convert.ToBase64String(hashbytes);
            return savedPasswordHash;
        }
    }
}
