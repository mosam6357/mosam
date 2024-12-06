using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int h = 8*(a-1)+aa.Sum();
            Console.WriteLine($"{h/24} {h%24}");
        }
    }
}