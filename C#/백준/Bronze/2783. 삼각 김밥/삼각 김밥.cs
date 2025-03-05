using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            double[] q = Array.ConvertAll(Console.ReadLine().Split(),double.Parse);
            double min = 1000000;
            min = min<q[0]/q[1]*1000?min:q[0]/q[1]*1000;
            int t = int.Parse(Console.ReadLine());
            for (int i=0;i<t;i++){
                double[] aa = Array.ConvertAll(Console.ReadLine().Split(),double.Parse);
                min = min<aa[0]/aa[1]*1000?min:aa[0]/aa[1]*1000;
            }
            Console.WriteLine($"{min:F2}");
        }
    }
}