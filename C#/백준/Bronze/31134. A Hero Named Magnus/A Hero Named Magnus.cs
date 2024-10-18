using System;
using System.Text;
using System.IO;

namespace q{
    class w{
        static void Main(){
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(Console.ReadLine());
            for (int i =0; i<a; i++){
                sb.Append($"{long.Parse(Console.ReadLine())*2-1}\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}