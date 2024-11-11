using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(a.Sum()>=a[4]*5){
                Console.WriteLine(0);
            }
            else{
                Console.WriteLine(a[4]*4-(a[0]+a[1]+a[2]+a[3]));
            }
        }
    }
}