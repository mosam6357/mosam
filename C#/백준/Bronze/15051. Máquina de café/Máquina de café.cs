using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[] aa = {(b+c*2)*2,(a+c)*2,(a*2+b)*2};
            Console.WriteLine(aa.Min());
        }
    }
}