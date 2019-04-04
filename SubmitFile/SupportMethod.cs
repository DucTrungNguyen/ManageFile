using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SubmitFile
{
    static class SupportMethod
    {

        public static string ConvertToSHA1(string pass)
        {
            SHA1CryptoServiceProvider sha512 = new SHA1CryptoServiceProvider();

            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
            bs = sha512.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2"));
            }
            return s.ToString();
            
        }
    }
}
