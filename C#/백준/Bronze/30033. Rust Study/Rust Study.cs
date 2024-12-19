using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt = 0;
            for(int i=0; i<a; i++){
                if(bb[i]>=aa[i]){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}