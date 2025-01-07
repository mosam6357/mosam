using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt = 0;
            for (int i=0;i<10;i++){
                if (aa[i]==bb[i]){
                    continue;
                }
                else if(aa[i]>bb[i]){
                    cnt++;
                }
                else{
                    cnt--;
                }
            }
            if (cnt==0){
                Console.WriteLine("D");
            }
            else{
                Console.WriteLine((cnt>0)?"A":"B");
            }
        }
    }
}