using System;

namespace q{
    class w{
        static void Main(){
            while(true){
                float[] aa = Array.ConvertAll(Console.ReadLine().Split(),float.Parse);
                if (aa[0]==aa[1] && aa[0]==0){
                    break;
                }
                if (aa[0]==0){
                    Console.WriteLine(90);
                }
                else{
                    Console.WriteLine(Math.Round(180*Math.Atan(aa[1]/aa[0])/Math.PI));
                }
            }
        }
    }
}