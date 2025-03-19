using System;
using System.Text;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            StringBuilder sb = new StringBuilder();
            int a = aa[0]; int b = aa[1];
            for (int i=0;i<a;i++){
                for (int j=0;j<b;j++){
                    if (j!=0){
                        sb.Append(" ");
                    }
                    sb.Append($"{i*b+j+1}");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}