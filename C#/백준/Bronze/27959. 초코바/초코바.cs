using System;

namespace q{
    class w{
        static void Main(){
            string[] a = Console.ReadLine().Split();
            int[] aa = Array.ConvertAll(a,int.Parse);
            if(aa[0]*100<aa[1]){
                Console.WriteLine("No");
            }
            else{
                Console.WriteLine("Yes");
            }
        }
    }
}