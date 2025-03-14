using System;

namespace q{
    class w{
        static void Main(String[] args){
            while(true){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                if(aa[0]==0 && aa[1]==0){
                    break;
                }
                Console.WriteLine(aa[0]+aa[1]);
            }
        }
    }
}