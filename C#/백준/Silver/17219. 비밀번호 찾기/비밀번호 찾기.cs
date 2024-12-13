using System;
using System.Text;
using System.IO;
using System.Collections.Generic; 

namespace q{
    class w{
        static void Main(){
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            int[] aa = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            Dictionary<string, string> dict = new Dictionary<string,string>();
            for (int i=0; i<aa[0]; i++){
                string[] bb = sr.ReadLine().Split();
                dict.Add(bb[0],bb[1]);
            }
            for (int i=0; i<aa[1]; i++){
                string s = sr.ReadLine();
                sb.Append(dict[s]).Append("\n");
            }
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}