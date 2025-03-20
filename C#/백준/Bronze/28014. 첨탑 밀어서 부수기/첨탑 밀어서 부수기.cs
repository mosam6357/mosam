using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt = 1;
            for (int i=1;i<a;i++){
                if (aa[i-1]<=aa[i]){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}