using System;

namespace q{
    class w{
        static void Main(){
            double a = double.Parse(Console.ReadLine());
            double[] aa = Array.ConvertAll(Console.ReadLine().Split(),double.Parse);
            double s = 0;
            for (int i=0;i<aa.Length;i++){
                if (aa[i]==-1){
                    a-=1;
                }
                else{
                    s+=aa[i];
                }
            }
            Console.WriteLine(s/a);
        }
    }
}