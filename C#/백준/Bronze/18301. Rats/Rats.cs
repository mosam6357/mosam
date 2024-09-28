using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int a = int.Parse(aa[0]);
            int b = int.Parse(aa[1]);
            int c = int.Parse(aa[2]);
            Console.WriteLine(((a+1)*(b+1))/(c+1)-1);
        }
    }
}