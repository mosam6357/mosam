using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            float s = 0;
            for (int i=0;i<a;i++){
                float[] aa = Array.ConvertAll(Console.ReadLine().Split(),float.Parse);
                s+=aa[0]*aa[1];
            }
            Console.WriteLine(s);
        }
    }
}