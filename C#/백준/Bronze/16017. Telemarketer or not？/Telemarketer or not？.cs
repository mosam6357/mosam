using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = new int[4];
            for (int i =0; i<4; i++){
                aa[i] = int.Parse(Console.ReadLine());
            }
            int b = aa[0]*aa[3];
            if((b==64 || b==72 || b==81) && (aa[1]==aa[2])){
                Console.WriteLine("ignore");
            }
            else{
                Console.WriteLine("answer");
            }
        }
    }
}