using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if(a[0]<a[1]*0.2){
                Console.WriteLine("weak");
            }
            else if(a[0]<a[1]*0.4){
                Console.WriteLine("normal");
            }
            else if(a[0]<a[1]*0.6){
                Console.WriteLine("strong");
            }
            else{
                Console.WriteLine("very strong");
            }
        }
    }
}