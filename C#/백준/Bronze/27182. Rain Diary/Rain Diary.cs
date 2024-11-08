using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(a[0]-7<=0){
                Console.WriteLine(a[1]+7);
            }
            else{
                Console.WriteLine(a[0]-7);
            }
        }
    }
}