using System;

namespace q{
    class w{
        static void Main(){
            String[] a = Console.ReadLine().Split();
            int[] b = Array.ConvertAll(a,int.Parse);
            Console.WriteLine(b[0]*56+b[1]*24+b[2]*14+b[3]*6);
        }
    }
}