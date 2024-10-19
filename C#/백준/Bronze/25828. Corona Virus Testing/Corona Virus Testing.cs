using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int aa = a[0]+a[1]*a[2];
            if(aa==a[0]*a[1]){
                Console.WriteLine(0);
            }
            else if(aa>a[0]*a[1]){
                Console.WriteLine(1);
            }
            else{
                Console.WriteLine(2);
            }
        }
    }
}