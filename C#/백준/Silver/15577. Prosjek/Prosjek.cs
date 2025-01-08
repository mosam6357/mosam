using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            float[] aa = new float[a];
            for (int i=0;i<a;i++){
                aa[i] = float.Parse(Console.ReadLine());
            }
            Array.Sort(aa);
            float avg = 0;
            for (int i=0;i<a-1;i++){
                avg = (aa[i]+aa[i+1])/2;
                aa[i+1]=avg;
            }
            Console.WriteLine(avg);
        }
    }
}