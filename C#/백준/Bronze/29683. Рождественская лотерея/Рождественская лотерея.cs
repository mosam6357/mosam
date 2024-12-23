using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int sum = 0;
            for (int i=0; i<aa[0]; i++){
                sum+=bb[i]/aa[1];
            }
            Console.WriteLine(sum);
        }
    }
}