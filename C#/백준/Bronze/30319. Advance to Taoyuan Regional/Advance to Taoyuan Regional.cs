using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split('-'),int.Parse);
            if (aa[1]<9 || (aa[1]==9 && aa[2]<=16)){
                Console.WriteLine("GOOD");
            }
            else{
                Console.WriteLine("TOO LATE");
            }
        }
    }
}