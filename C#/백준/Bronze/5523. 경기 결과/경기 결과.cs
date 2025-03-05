using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int cnt1 = 0;
            int cnt2 = 0;
            for (int i=1;i<=a;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                if (aa[0]>aa[1]){
                    cnt1++;
                }
                else if(aa[0]<aa[1]){
                    cnt2++;
                }
            }
            Console.WriteLine($"{cnt1} {cnt2}");
        }
    }
}