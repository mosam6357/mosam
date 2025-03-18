using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = int.Parse(Console.ReadLine());
            int[] n = new int[a];
            for (int i=0;i<a;i++){
                int total =0;
                for (int j=0;j<3;j++){
                    int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                    total+=aa[0]*bb[0]+aa[1]*bb[1]+aa[2]*bb[2];
                }
                n[i] = total;
            }
            Console.WriteLine(n.Max());
        }
    }
}