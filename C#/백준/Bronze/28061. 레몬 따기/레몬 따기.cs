using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            for (int i=0;i<a;i++){
                aa[i]-=a-i;
            }
            Console.WriteLine(aa.Max());
        }
    }
}