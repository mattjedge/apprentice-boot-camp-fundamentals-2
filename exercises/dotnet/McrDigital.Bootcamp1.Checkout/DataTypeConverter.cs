using System;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public static class DataTypeConverter
    {
        public static string ParseHexBinary(string s)
        {
            int len = s.Length;
            byte[] data = new byte[len / 2];
            for (int i = 0; i < len; i += 2)
            {
                data[i / 2] = Convert.ToByte(s.Substring(i, 2), 16);
            }

            return Encoding.UTF8.GetString(data);
        }
    }
}