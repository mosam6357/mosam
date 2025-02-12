using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int ans = 0;
            for (int i=0;i<a;i++){
                int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                if (aa[i]==1 && bb[0]<bb[1]){
                    ans+=bb[1]-bb[0];
                }
            }
            Console.WriteLine(ans);
        }
    }
}