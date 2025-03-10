using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int total = 0;
            for (int i=0;i<a;i++){
                total+=Math.Abs(aa[i]-bb[i]);
            }
            Console.WriteLine(total/2);
        }
    }
}