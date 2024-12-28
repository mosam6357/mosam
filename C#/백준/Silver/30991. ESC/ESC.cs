using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            long[] aa = {0,0,1};
            for (int i=0; i<a; i++){
                long s1 = aa[0]-aa[2];
                long s2 = aa[1]+aa[2];
                long s3 = 2*aa[0]-2*aa[1]+aa[2];
                aa[0] = s1;
                aa[1] = s2;
                aa[2] = s3;
            }
            Console.WriteLine(aa.Sum());
        }
    }
}