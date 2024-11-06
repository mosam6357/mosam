using System;

namespace q{
    class w{
        static void Main(){
            int[] a = new int[2];
            for (int i =0;i<2;i++){
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(a.Min()*50);
        }
    }
}