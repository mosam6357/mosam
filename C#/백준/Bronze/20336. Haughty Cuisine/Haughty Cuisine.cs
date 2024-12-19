using System;

namespace q{
    class w{
        static void Main(){
            int q = int.Parse(Console.ReadLine());
            string[] a = Console.ReadLine().Split();
            for (int i=0; i<int.Parse(a[0])+1; i++){
                Console.WriteLine(a[i]);
            }
        }
    }
}