using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt = 0;
            int mcnt = 0;
            for (int i=0;i<a;i++){
                if (aa[i]==0){
                    mcnt = mcnt>cnt?mcnt:cnt;
                    cnt = 0;
                }
                else{
                    cnt++;
                }
            }
            mcnt = mcnt>cnt?mcnt:cnt;
            Console.WriteLine(mcnt);
        }
    }
}