using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DotNetTraining.Controller
{
   static class ReadWrite
    {
        public static string read()
        {
            FileStream fstream = File.OpenRead("password.txt");
            byte[] array = new byte[fstream.Length];
            fstream.Read(array, 0, array.Length);
            fstream.Close();
            string text = Encoding.Default.GetString(array);
            return text;
        }


        public static void Write(string _s)
        {
            FileStream fs = new FileStream("password.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            StringBuilder output = new StringBuilder();
            output.Append(_s);
            writer.WriteLine(output.ToString());
            writer.Close();
        }

    }
}
