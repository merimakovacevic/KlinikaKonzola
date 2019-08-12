using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Klase
{
    public class Utilities
    {

        public static string formatiranDatum(DateTime d)
        {
            return d.Day + "/" + d.Month + "/" + d.Year;
        }

        public static string formatiranoVrijeme(DateTime d)
        {
            return d.Day + "/" + d.Month + "/" + d.Year + " " + d.Hour + ":" + d.Minute;
        }

        public static bool TacanMaticniBroj(string maticni, DateTime datumRodjenja)
        {
            try
            {
                int danMat, mjesecMat, godMat;
                if (maticni.Length != 13) return false;
                danMat = Convert.ToInt32(maticni.Substring(0, 2));
                mjesecMat = Convert.ToInt32(maticni.Substring(2, 2));
                godMat = Convert.ToInt32(maticni.Substring(4, 3));
                int test = Convert.ToInt32(maticni.Substring(7, 6));
                if (danMat == datumRodjenja.Day && mjesecMat == datumRodjenja.Month && datumRodjenja.Year % 1000 == godMat)
                    return true;
                else return false;
            }
            catch (FormatException ex)
            {
                return false;
            }
        }

        public static string DajMD5(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }
}
