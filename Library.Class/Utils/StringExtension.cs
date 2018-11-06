using System;
using System.Text;

namespace Library.Class.Utils
{
    public static class StringExtension
    {
        public static string ConvertToMD5(this string passWord)
        {
            if (string.IsNullOrEmpty(passWord)) return "";
            var password = (passWord += "|2d331cca-f6c0-40c0-bb43-6e32989c2881");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
        }

        public static int ToInt32(object value)
        {
            if (value == null || value == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(value);
            }
        }
    }
}
