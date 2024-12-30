using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0; i<a; i++){
                int ans = 0;
                int b = int.Parse(Console.ReadLine());
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                Array.Sort(aa);
                Array.Sort(bb);
                Array.Reverse(bb);
                for (int j=0;j<b;j++){
                    ans+=aa[j]*bb[j];
                }
                Console.WriteLine($"Case #{i+1}: {ans}");
            }
            
        }
    }
}