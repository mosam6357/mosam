using System;

namespace q{
    class w{
        static void Main(){
            int p = 0;
            int time = 0;
            int[] aa = new int[11];
            for (int i=0;i<11;i++){
                int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                aa[i] = bb[0];
                p+=bb[1]*20;
            }
            Array.Sort(aa);
            for (int i=0;i<11;i++){
                time += aa[i];
                p+=time;
            }
            Console.WriteLine(p);
        }
    }
}