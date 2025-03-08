using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] q = new int[5];
            for (int i=0;i<a;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                if(aa[0]==0 || aa[1]==0){
                    q[0]++;
                }
                else if(aa[0]>0 && aa[1]>0){
                    q[1]++;
                }
                else if(aa[0]<0 && aa[1]>0){
                    q[2]++;
                }
                else if(aa[0]<0 && aa[1]<0){
                    q[3]++;
                }
                else{
                    q[4]++;
                }
            }
           for (int i=0;i<4;i++){
               Console.WriteLine($"Q{i+1}: {q[i+1]}");
           }
            Console.WriteLine($"AXIS: {q[0]}");
        }
    }
}