using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int a =  int.Parse(Console.ReadLine());
            int[] aa = new int[a];
            for (int i=0;i<a;i++){
                aa[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(aa);
            for (int i=0;i<a;i++){
                aa[i]*=a-i;
            }
            Console.WriteLine(aa.Max());
        }
    }
}