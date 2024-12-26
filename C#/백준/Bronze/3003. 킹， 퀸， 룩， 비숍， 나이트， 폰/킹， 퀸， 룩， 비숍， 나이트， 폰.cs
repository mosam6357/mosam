using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int[] bb = {1,1,2,2,2,8};
            int[] cc = new int[6];
            for (int i =0; i<6; i++){
                cc[i] = bb[i]-int.Parse(aa[i]);
            }
            for(int j =0; j<6; j++){
                Console.Write($"{cc[j]} ");
            }
        }
    }
}