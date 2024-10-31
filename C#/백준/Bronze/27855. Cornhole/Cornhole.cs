using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0]*3+aa[1];
            int b = bb[0]*3+bb[1];
            if(a==b){
                Console.WriteLine("NO SCORE");
            }
            else if(a>b){
                Console.WriteLine($"1 {a-b}");
            }
            else{
                Console.WriteLine($"2 {b-a}");
            }
        }
    }
}