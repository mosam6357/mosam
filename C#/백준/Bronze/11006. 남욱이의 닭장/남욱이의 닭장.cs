using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0; i<a; i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int s = aa[1]*2-aa[0];
                Console.WriteLine($"{s} {aa[1]-s}");
            }
        }
    }
}