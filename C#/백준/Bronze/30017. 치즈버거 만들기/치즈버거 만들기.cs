using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if(a[0]<=a[1]){
                Console.WriteLine(a[0]*2-1);
            }
            else{
                Console.WriteLine(a[1]*2+1);
            }
        }
    }
}