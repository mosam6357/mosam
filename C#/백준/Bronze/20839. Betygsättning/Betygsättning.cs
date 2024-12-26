using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(aa[0]==bb[0] && aa[1]==bb[1] && aa[2]==bb[2]){
                Console.WriteLine("A");
            }
            else if(aa[1]==bb[1] && aa[2]==bb[2]){
                if(bb[0]>=(aa[0]+1)/2){
                    Console.WriteLine("B");
                }
                else{
                    Console.WriteLine("C");
                }
            }
            else{
                if(bb[1]>=(aa[1]+1)/2){
                    Console.WriteLine("D");
                }
                else{
                    Console.WriteLine("E");
                }
            }
        }
    }
}