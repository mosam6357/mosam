using System;

namespace q{
    class w{
        static void Main(){
            int[] aa=Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int sum=0;
            for (int i=0; i<3; i++){
                sum+=aa.Max()-aa[i];
            }
            Console.WriteLine(sum);
        }
    }
}