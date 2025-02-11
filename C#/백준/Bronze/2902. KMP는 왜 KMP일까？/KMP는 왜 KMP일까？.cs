using System;

namespace q{
    class w{
        static void Main(){
            String[] aa = Console.ReadLine().Split("-");
            for (int i=0;i<aa.Length;i++){
                Console.Write(aa[i][0]);
            }
        }
    }
}