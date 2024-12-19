using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0]; int b=aa[1];
            Console.WriteLine((a+b>a-b)?a+b:a-b);
            Console.WriteLine((a+b<a-b)?a+b:a-b);
        }
    }
}