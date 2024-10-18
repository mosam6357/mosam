using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i =0; i<a; i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if((aa[0]<=1 && aa[1]<=2) || (aa[0]<=2 && aa[1]<=1)){
                    Console.WriteLine("Yes");
                }
                else{
                    Console.WriteLine("No");
                }
            }
        }
    }
}