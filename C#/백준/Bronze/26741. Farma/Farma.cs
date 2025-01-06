using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0]; int b = aa[1];
            int y = (b-a*2)/2;
            int x = a-y;
            Console.WriteLine($"{x} {y}");
        }
    }
}