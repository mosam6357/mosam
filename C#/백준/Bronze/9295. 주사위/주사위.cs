using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for(int i =0; i<a; i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                Console.WriteLine($"Case {i+1}: {aa.Sum()}");
            }
        }
    }
}