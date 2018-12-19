using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Security
{
    public class EncrypteHelper
    {
        public static string Sha1HashEncrypt(string input)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var result = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BitConverter.ToString(result);
        }

        private static byte[] MakeMd5(byte[] original)
        {
            using (var hashmd5 = new MD5CryptoServiceProvider())
            {
                byte[] keyhash = hashmd5.ComputeHash(original);
                return keyhash;
            }
        }
    }
}
