using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(bb[0]<0 && bb[1]>=10){
                Console.WriteLine("A storm warning for tomorrow! Be careful and stay home if possible!");
            }
            else if(aa[0]>bb[0]){
                Console.WriteLine("MCHS warns! Low temperature is expected tomorrow.");
            }
            else if(aa[1]<bb[1]){
                Console.WriteLine("MCHS warns! Strong wind is expected tomorrow.");
            }
            else{
                Console.WriteLine("No message");
            }
        }
    }
}