using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                double[] aa = Array.ConvertAll(Console.ReadLine().Split(),double.Parse);
                double n = aa[0];
                double avg = (aa.Sum()-n)/n;
                double cnt = 0;
                for (int j=1;j<aa.Length;j++){
                    if (aa[j]>avg){
                        cnt++;
                    }
                }
                Console.WriteLine($"{(cnt/n*100):N3}%");
            }
        }
    }
}