using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            String[] b = Console.ReadLine().Split();
            int[] aa = Array.ConvertAll(b,int.Parse);
            Array.Sort(aa);
            Array.Reverse(aa);
            for (int i =0; i<a; i++){
                aa[i] += i+2;
            }
            Console.WriteLine(aa.Max());
        }
    }
}