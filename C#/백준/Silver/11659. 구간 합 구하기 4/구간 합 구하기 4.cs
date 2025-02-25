using System;
using System.Text;

namespace q{
    class w{
        static void Main(){
            StringBuilder sb = new StringBuilder();
            int[] q = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = q[0]; int b = q[1];
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] sum = new int[a];
            int total = 0;
            for (int i=0;i<a;i++){
                total+=aa[i];
                sum[i] = total;
            }
            for (int i=0;i<b;i++){
                int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int s = bb[0]; int e = bb[1];
                if (s<2){
                    sb.AppendLine(sum[e-1].ToString());
                }
                else{
                    sb.AppendLine((sum[e-1]-sum[s-2]).ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}