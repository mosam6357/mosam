using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0; i<a; i++){
                int b = int.Parse(Console.ReadLine());
                for (int j =0; j<b; j++){
                    int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                    Console.WriteLine($"{aa[0]+aa[1]} {aa[0]*aa[1]}");
                }
            }
        }
    }
}