using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int sumt = 0; int sump = a/bb[1]; int p = a%bb[1];
            for (int i=0; i<aa.Length; i++){
                sumt+=aa[i]/bb[0];
                if(aa[i]%bb[0]!=0){
                    sumt++;
                }
            }
            Console.WriteLine($"{sumt}\n{sump} {p}");
        }
    }
}