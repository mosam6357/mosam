using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int total = aa[0];
            for (int i=1;i<a;i++){
                if (aa[i]!=aa[i-1]+1){
                    total+=aa[i];
                }
            }
            Console.WriteLine(total);
        }
    }
}