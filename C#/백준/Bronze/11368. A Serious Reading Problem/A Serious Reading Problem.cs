using System;

namespace q{
    class w{
        static void Main(){
            while(true){
                long s1 = 1;
                long s2 = 1;
                long ans = 1;
                long[] aa = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
                if (aa[0]==aa[1] && aa[1]==aa[2] && aa[2]==aa[3] && aa[0]==0){
                    break;
                }
                for (int i=0; i<aa[1]; i++){
                    s1*=aa[0];
                }
                for (int i=0; i<aa[2]; i++){
                    s2*=s1;
                }
                for (int i=0; i<aa[3]; i++){
                    ans*=s2;
                }
                Console.WriteLine(ans);
            }
        }
    }
}