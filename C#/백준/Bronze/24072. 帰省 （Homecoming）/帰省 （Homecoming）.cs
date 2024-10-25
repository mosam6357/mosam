using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(a[0]<=a[2] && a[2]<a[1]){
                Console.WriteLine(1);
            }
            else{
                Console.WriteLine(0);
            }
        }
    }
}