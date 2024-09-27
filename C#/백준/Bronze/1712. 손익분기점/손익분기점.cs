using System;

namespace q{
    class w{
        static void Main(){
            string[] a = Console.ReadLine().Split();
            int[] aa = Array.ConvertAll(a,int.Parse);
            if(aa[1]>=aa[2]){
                Console.WriteLine(-1);
            }
            else{
                int b = aa[2]-aa[1];
                Console.WriteLine(aa[0]/b+1);
            }
        }
    }
}