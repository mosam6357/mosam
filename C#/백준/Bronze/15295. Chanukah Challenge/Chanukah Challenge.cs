using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int b = aa[0];
                int c = aa[1];
                Console.WriteLine($"{b} {(c*(c+1))/2+c}");
            }
        }
    }
}