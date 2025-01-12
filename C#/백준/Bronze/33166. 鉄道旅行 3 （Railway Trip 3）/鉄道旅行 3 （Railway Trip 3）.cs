using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if (aa[0]>=aa[1]){
                Console.WriteLine(aa[1]*bb[0]);
            }
            else{
                Console.WriteLine(aa[0]*bb[0]+(aa[1]-aa[0])*bb[1]);
            }
        }
    }
}