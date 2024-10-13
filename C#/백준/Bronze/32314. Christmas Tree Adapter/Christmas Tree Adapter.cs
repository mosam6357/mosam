using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            String[] aa = Console.ReadLine().Split();
            int b =int.Parse(aa[0]);
            int c = int.Parse(aa[1]);
            Console.WriteLine(b/c>=a?1:0);
        }
    }
}