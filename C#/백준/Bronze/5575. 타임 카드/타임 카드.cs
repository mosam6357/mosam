using System;

namespace q{
    class w{
        static void Main(){
            for (int i=0; i<3; i++){
                int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int t1 = a[0]*3600+a[1]*60+a[2];
                int t2 = a[3]*3600+a[4]*60+a[5];
                int time = t2-t1;
                Console.WriteLine($"{time/3600} {(time%3600)/60} {time%60}");
            }
        }
    }
}