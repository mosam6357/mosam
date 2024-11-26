using System;

namespace q{
    class w{
        static void Main(){
            float[] a = Array.ConvertAll(Console.ReadLine().Split(),float.Parse);
            float b = a[0]-(a[0]*(a[1]/100));
            if(b>=100){
                Console.WriteLine(0);
            }
            else{
                Console.WriteLine(1);
            }
        }
    }
}