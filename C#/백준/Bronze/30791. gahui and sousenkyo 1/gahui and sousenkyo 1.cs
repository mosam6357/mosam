using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int cnt =0;
            for (int i=0; i<5; i++){
                if(a[i]!=a.Max() && a.Max()-a[i]<=1000){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}