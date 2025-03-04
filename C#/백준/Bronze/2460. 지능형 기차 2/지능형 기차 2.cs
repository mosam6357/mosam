using System;

namespace q{
    class w{
        static void Main(){
            int p = 0;
            int max = 0;
            for (int i=0;i<10;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                p += aa[1]-aa[0];
                max = max>p?max:p;
            }
            Console.WriteLine(max);
        }
    }
}