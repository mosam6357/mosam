using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(a[1]<=2){
                Console.WriteLine("NEWBIE!");
            }
            else if(a[1]<=a[0]){
                Console.WriteLine("OLDBIE!");
            }
            else{
                Console.WriteLine("TLE!");
            }
        }
    }
}