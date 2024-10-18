using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if(a.Sum()<100){
                if(a[0]==a.Min()){
                    Console.WriteLine("Soongsil");
                }
                else if(a[1]==a.Min()){
                    Console.WriteLine("Korea");
                }
                else{
                    Console.WriteLine("Hanyang");
                }
            }
            else{
                Console.WriteLine("OK");
            }
        }
    }
}