using System;

namespace q{
    class w{
        static void Main(){
            long[] aa = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
            long a  = aa[0]; long b = aa[1];
            if (a>b){
                Console.WriteLine((a*(a+1))/2-(b*(b-1))/2);
            }
            else{
                Console.WriteLine((b*(b+1))/2-(a*(a-1))/2);
            }
        }
    }
}