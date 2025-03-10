using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int e = 0;
            int m = 0;
            int p = 0;
            for (int i=0;i<a;i++){
                if(i!=0){
                    if(p>aa[i]){
                        e+=p-aa[i];
                    }
                    else{
                        m+=aa[i]-p;
                    }
                }
                p = aa[i];
            }
            Console.WriteLine($"{e} {m}");
        }
    }
}