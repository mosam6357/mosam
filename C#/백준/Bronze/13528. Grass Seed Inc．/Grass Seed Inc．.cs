using System;

namespace q{
    class w{
        static void Main(){
            float q = float.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            float e = 0;
            for (int i=0;i<a;i++){
                float[] aa = Array.ConvertAll(Console.ReadLine().Split(),float.Parse);
                e+=aa[0]*aa[1];
            }
            Console.WriteLine(q*e);
        }
    }
}