using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt = 0;
            for (int i=0; i<a[0]; i++){
                if(aa[i]<=a[1])cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}