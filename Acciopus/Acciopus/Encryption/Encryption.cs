using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acciopus.Encryption
{
    internal class Encryption
    {

        public static String EncryptPassword(String Password)
        {
            Password =  SHA256Sifrele(MD5Sifrele(Password));
            return Password;
        }
        public static String MD5Sifrele(String SifrelenecekVeri)
        {
            MD5 md = MD5.Create();
            byte[] dizi = Encoding.UTF8.GetBytes(SifrelenecekVeri);
            dizi = md.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();

            foreach (byte b in dizi)
            {
                sb.Append(b.ToString("x2"));
            }


            return sb.ToString();
        }


        private static String SHA256Sifrele(String SifrelenecekVeri)
        {
            SHA256 sh = SHA256.Create();
            byte[] dizi = Encoding.UTF8.GetBytes(SifrelenecekVeri);
            dizi = sh.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();

            foreach (byte b in dizi)
            {
                sb.Append(b.ToString("x2"));
            }


            return sb.ToString();
        }
    }


}
