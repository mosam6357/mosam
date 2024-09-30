using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i =0; i<a; i++){
                string[] aa = Console.ReadLine().Split();
                int b = int.Parse(aa[0]);
                int c = int.Parse(aa[1]);
                Console.WriteLine(b-(c/7)+(c/4));
            }
        }
    }
}