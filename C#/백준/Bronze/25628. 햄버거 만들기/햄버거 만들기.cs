using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int a = int.Parse(aa[0])/2;
            int b = int.Parse(aa[1]);
            int burger = a<b?a:b;
            Console.WriteLine(burger);
        }
    }
}