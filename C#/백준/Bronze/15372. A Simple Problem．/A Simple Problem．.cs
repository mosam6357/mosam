using System;
using System.Text;
using System.IO;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            long b;
            for (int i=0; i<a; i++){
                b = int.Parse(Console.ReadLine());
                sb.Append($"{b*b}\n");
            }
            Console.Write(sb.ToString());
        }
    }
}