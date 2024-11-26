using System;

namespace q{
    class w{
        static void Main(){
            int q = int.Parse(Console.ReadLine());
            for (int i=0; i<q; i++){
                int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                if(a[1]>=a[2]){
                    Console.WriteLine(0);
                }
                else{
                    Console.WriteLine((a[2]-a[1])*(a[0]*2-1));
                }
            }
        }
    }
}