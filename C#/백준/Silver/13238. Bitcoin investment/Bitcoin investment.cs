using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int max = 0;
            for (int i=0;i<a;i++){
                for (int j=i;j<a;j++){
                    max = max>aa[j]-aa[i]?max:aa[j]-aa[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}