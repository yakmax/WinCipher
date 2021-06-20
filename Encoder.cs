using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCipher
{
    class Encoder
    {
        public static string Code(string t)
        {
            Encoding encoding = Encoding.Unicode;
            byte[] t_bytes = encoding.GetBytes(t);
            string str="";
            for (int t_count = 0; t_count < t_bytes.Length; t_count++)
                str += t_bytes[t_count];
            
                
                //ct_bytes[t_count] = (byte)((int)t_bytes[t_count] ^ (int)g_bytes[g_count]);
            
            //return encoding.GetString(t_bytes);
            return str;
        }
        public static string Crypt(string t, string g)
        {
            Encoding encoding = Encoding.Unicode;
            byte[] t_bytes = encoding.GetBytes(t);
            byte[] g_bytes = encoding.GetBytes(g);
            byte[] ct_bytes = new byte[t_bytes.Length]; // = encoding.GetBytes(t);
            int g_count = 0;
            for (int t_count = 0; t_count < t_bytes.Length; t_count++)
            {
                g_count++;
                if (g_count == g_bytes.Length) g_count = 0;
                ct_bytes[t_count] = (byte)((int)t_bytes[t_count] ^ (int)g_bytes[g_count]);
            }
            return encoding.GetString(ct_bytes);
        }
    }
}
