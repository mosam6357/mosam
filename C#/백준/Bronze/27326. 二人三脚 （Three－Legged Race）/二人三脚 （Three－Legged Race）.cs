using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] x = new int[a];
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            for (int i=0;i<aa.Length;i++){
                x[aa[i]-1]++;
            }
            for (int i=0;i<a;i++){
                if(x[i]==1){
                    Console.WriteLine(i+1);
                    break;
                }
            }
        }
    }
}