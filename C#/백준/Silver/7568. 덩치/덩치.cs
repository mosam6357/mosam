using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[,] aa = new int[a,2];
            for (int i=0;i<a;i++){
                int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                aa[i,0] = bb[0];
                aa[i,1] = bb[1];
            }
            for (int i=0;i<a;i++){
                int s = 1;
                for  (int j=0;j<a;j++){
                    if(aa[i,0]<aa[j,0] && aa[i,1]<aa[j,1]){
                        s++;
                    }
                }
                Console.Write($"{s} ");
            }
        }
    }
}