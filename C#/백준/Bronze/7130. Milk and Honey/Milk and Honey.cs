using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i =0;i<a;i++){
                int[] bb =Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int q = aa[0]*bb[0];
                int w = aa[1]*bb[1];
                sum+=q>w?q:w;
            }
            Console.WriteLine(sum);
        }
    }
}