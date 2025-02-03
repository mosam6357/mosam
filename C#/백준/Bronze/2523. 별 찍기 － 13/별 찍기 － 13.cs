using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<2*a-1;i++){
                for (int j=0;j<a-Math.Abs(a-(i+1));j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}