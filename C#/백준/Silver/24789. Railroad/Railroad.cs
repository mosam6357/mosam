using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if (aa[1]%2==0){
                Console.WriteLine("possible");
            }
            else{
                Console.WriteLine("impossible");
            }
        }
    }
}