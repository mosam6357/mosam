using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int time = (a[2]-a[0])*60+(a[3]-a[1]);
            time = time<0?time+1440:time;
            Console.WriteLine($"{time} {time/30}");
        }
    }
}