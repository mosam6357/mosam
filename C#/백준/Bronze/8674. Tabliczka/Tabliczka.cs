using System;

namespace q{
    class w{
        static void Main(){
            long[] a = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
            if(a[0]*a[1]%2==1){
                Console.WriteLine(a.Min());
            }
            else{
                Console.WriteLine(0);
            }
        }
    }
}