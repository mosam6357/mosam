using System;
using System.Text;
using System.IO;

namespace q{
    class w{
        static void Main(){
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int a = int.Parse(sr.ReadLine());
            for (int i =0; i<a; i++){
                sb.Append($"{long.Parse(sr.ReadLine())*2-1}\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}