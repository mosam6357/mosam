using System;

namespace q{
    class w{
        static void Main(){
            string[] a = Console.ReadLine().Split();
            int[] aa = Array.ConvertAll(a,int.Parse);
            if(aa[0]*aa[1]>aa[2]*aa[3]){
                Console.WriteLine('M');
            }
            else if(aa[0]*aa[1] == aa[2]*aa[3]){
                Console.WriteLine('E');
            }
            else{
                Console.WriteLine('P');
            }
        }
    }
}