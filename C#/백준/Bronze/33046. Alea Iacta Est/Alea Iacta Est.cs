using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int p = (aa.Sum()+bb.Sum()-1)%4;
            Console.WriteLine((p==0)?4:p);
        }
    }
}