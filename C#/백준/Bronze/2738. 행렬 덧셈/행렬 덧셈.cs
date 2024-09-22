using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int a = int.Parse(aa[0]);
            int b = int.Parse(aa[1]);
            int[,] bb = new int[a,b];
            for (int i=0; i<a; i++){
                string[] cc = Console.ReadLine().Split();
                for(int j =0; j<b; j++){
                    bb[i,j] = int.Parse(cc[j]);
                }
            }
            for (int i=0; i<a; i++){
                string[] cc = Console.ReadLine().Split();
                for(int j =0; j<b; j++){
                    bb[i,j] += int.Parse(cc[j]);
                }
            }
            for (int i =0; i<a; i++){
                for (int j = 0; j<b; j++){
                    Console.Write($"{bb[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}