using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Array.Sort(aa);
            int st=0; int t=0;
            for(int i=0; i<a; i++){
                st = st+aa[i];
                t += st;
            }
            Console.WriteLine(t);
        }
    }
}