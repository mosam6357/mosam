using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            string[] aa = Console.ReadLine().Split();
            int[] b = new int[a];
            for (int i =0; i<a; i++){
                b[i] = int.Parse(aa[i]);
            }
            Console.WriteLine(b.Max()*b.Min());
        }
    }
}