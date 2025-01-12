using System;
using System.Linq;
namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0]; int b = aa[1];
            int[] q = new int[a];
            for (int i=0;i<b;i++){
                int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int c = bb[0]; int d = bb[1];
                for (int j=c-1;j<a;j+=d){
                    q[j] = 1;
                }
            }
            Console.WriteLine(a-q.Sum());
        }
    }
}