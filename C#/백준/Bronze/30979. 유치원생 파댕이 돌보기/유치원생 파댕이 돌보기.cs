using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string[] cc = Console.ReadLine().Split();
            int[] aa = Array.ConvertAll(cc,int.Parse);
            if(a<=aa.Sum()){
                Console.WriteLine("Padaeng_i Happy");
            }
            else{
                Console.WriteLine("Padaeng_i Cry");
            }
        }
    }
}