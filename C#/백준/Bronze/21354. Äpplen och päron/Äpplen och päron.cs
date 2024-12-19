using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            a[0]*=7; a[1]*=13;
            if(a[0]>a[1]){
                Console.WriteLine("Axel");
            }
            else if(a[0]<a[1]){
                Console.WriteLine("Petra");
            }
            else{
                Console.WriteLine("lika");
            }
        }
    }
}