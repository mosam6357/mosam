using System;

namespace q{
    class w{
        static void Main(){
            int q = int.Parse(Console.ReadLine());
            int[] aa = new int[q];
            for (int i= 0; i<q; i++){
                int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int score = a[0]*(a[1]+a[2]);
                if(a[0]==a[1]+a[2]){
                    score*=2;
                }
                aa[i] = score;
            }
            Console.WriteLine(aa.Max());
        }
    }
}