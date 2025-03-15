using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt = 0;
            for (int i=0;i<aa[0];i++){
                aa[1]-=bb[i];
                if (aa[1]<0){
                    break;
                }
                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}