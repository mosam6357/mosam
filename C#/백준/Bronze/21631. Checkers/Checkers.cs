using System;

namespace q{
    class w{
        static void Main(){
            long[] aa = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
            if(aa[1]<=aa[0]){
                Console.WriteLine(aa[1]);
            }
            else{
                Console.WriteLine(aa[0]+1);
            }
        }
    }
}