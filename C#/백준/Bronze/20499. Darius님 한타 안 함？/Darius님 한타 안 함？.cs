using System;

namespace q{
    class w{
        static void Main(){
            string[] aaa = Console.ReadLine().Split("/");
            int[] aa = Array.ConvertAll(aaa,int.Parse);
            if((aa[1]==0)||(aa[0]+aa[2]<aa[1])){
                Console.WriteLine("hasu");
            }
            else{
                Console.WriteLine("gosu");
            }
        }
    }
}