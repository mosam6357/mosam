using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int s = (a[1]/a[3])*(a[2]/a[3]);
            Console.WriteLine(a[0]<s?a[0]:s);
        }
    }
}