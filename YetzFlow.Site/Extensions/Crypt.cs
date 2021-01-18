using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace YetzFlow.Site.Extensions
{
    public static class Encrypt
    {
        public static string Crypt(this string text)
        {
            return text;

                //Convert.ToBase64String(
                //ProtectedData.Protect(
                //    Encoding.Unicode.GetBytes(text), null, DataProtectionScope.LocalMachine));
        }

        public static string Decrypt(this string text)
        {
            return text;
                //Encoding.Unicode.GetString(
                //ProtectedData.Unprotect(
                //     Convert.FromBase64String(text), null, DataProtectionScope.LocalMachine));
        }
    }
}