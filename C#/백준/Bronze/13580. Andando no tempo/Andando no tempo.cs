using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(a[0]==a[1] || a[1]==a[2] || a[2]==a[0]){
                Console.WriteLine("S");
            }
            else if(a[0]+a[1]==a[2] || a[1]+a[2]==a[0] || a[2]+a[0]==a[1]){
                Console.WriteLine("S");
            }
            else{
                Console.WriteLine("N");
            }
        }
    }
}