using System;

namespace q{
    class w{
        static void Main(){
            int cnt = 0;
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            for (int i=0;i<aa[2];i++){
                if(bb[i]>=aa[0] && bb[i]<=aa[1]){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}