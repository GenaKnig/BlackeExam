using BlakeSharp;
using BlakeSharpDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convector
{
   public static class Blacy
    {
        
        public static string sea;
        public static string sea2;
        public static string login1 ;/*AlisaGet*/
        public static string login2;/*Bobafet*/
        public static byte[] Hash256;
        public static byte[] Hash2566;
        public static string key;
        private const StringComparison StrCaseIgnoreCmp =
        StringComparison.OrdinalIgnoreCase;

       public static string Random32()
        {
            string characters = @"0123456789";
            int lengthOfPassword = 32;
            Random random = new Random();

            var chars = new char[lengthOfPassword];

            for (var i = 0; i < lengthOfPassword; i++)
            {
                chars[i] = characters[random.Next(0, characters.Length)];
            }

            string s = new string(chars);
            login1 = "AlisaGet";
            login2 = "Bobafet";

            sea2 = s; 
            sea = login1+s+  login2+key; 
            return sea;
        }
        public static void HashString(string data)
        {


            
            string strText;
            strText = data;
            Encoding enc;
            enc = Encoding.Default;

            if (enc == null) enc = Encoding.Default;

            //Console.WriteLine(@"Text '" + strText + @"' (encoding " +
            //    enc.WebName + ")");

            byte[] pbData = enc.GetBytes(strText);


            Blake256 blake256 = new Blake256();
            byte[] pbHash256 = blake256.ComputeHash(pbData);
            Console.WriteLine(MemUtil.ByteArrayToHexString(pbHash256));
            Hash256 = pbHash256;
            
            MemUtil.ByteArrayToHexString(Hash256);



            Console.WriteLine();
        }
        public static string Random33()
        {
            string characters = @"abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            int lengthOfPassword = 32;
            Random random = new Random();

            var chars = new char[lengthOfPassword];

            for (var i = 0; i < lengthOfPassword; i++)
            {
                chars[i] = characters[random.Next(0, characters.Length)];
            }
            string k = new string(chars);
            key = k;
            return key;

        }
        public static void HashString2()
        {

            
            
           string strText;
            strText = sea;
            Encoding enc;
            enc = Encoding.Default;
            //Console.Write("\tstrText: ");
            //strText = Convert.ToString(Console.ReadLine());
            if (enc == null) enc = Encoding.Default;

            Console.WriteLine(@"Text '" + strText + @"' (encoding " +
                enc.WebName + ")");

            byte[] pbData = enc.GetBytes(strText);

            Blake256 blake256 = new Blake256();
            byte[] pbHash256 = blake256.ComputeHash(pbData);
            Console.WriteLine("BLAKE-256:");
            Console.WriteLine(MemUtil.ByteArrayToHexString(pbHash256));
            Hash2566 = pbHash256;

            MemUtil.ByteArrayToHexString(Hash2566);



            Console.WriteLine();
        }
    }
}
