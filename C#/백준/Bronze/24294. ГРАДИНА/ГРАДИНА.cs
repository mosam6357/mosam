using System;

namespace q{
    class w{
        static void Main(){
            int[] a = new int[4];
            int tile = 4;
            for (int i=0; i<4; i++){
                a[i] = int.Parse(Console.ReadLine());
            }
            tile += a[0]>a[2]?a[0]*2:a[2]*2;
            tile += (a[1]+a[3])*2;
            Console.WriteLine(tile);
        }
    }
}