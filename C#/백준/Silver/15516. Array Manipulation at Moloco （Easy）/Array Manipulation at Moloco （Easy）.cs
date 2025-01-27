using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = new int[a];
            for (int i=0;i<a;i++){
                int cnt = 0;
                aa[i] = int.Parse(Console.ReadLine());
                for (int j=0;j<i;j++){
                    if (aa[i]>aa[j])
                        cnt++;
                }
                Console.WriteLine(cnt);
            }
        }
    }
}