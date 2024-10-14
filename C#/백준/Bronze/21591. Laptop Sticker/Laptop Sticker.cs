using System;

namespace q{
    class w{
        static void Main(){
            string[] aaa  = Console.ReadLine().Split();
            int[] aa = Array.ConvertAll(aaa,int.Parse);
            if(aa[0]>aa[2]+1 && aa[1]>aa[3]+1){
                Console.WriteLine(1);
            }
            else{
                Console.WriteLine(0);
            }
        }
    }
}