using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i<a; i++){
                String[] aa = Console.ReadLine().Split();
                for(int j =2; j<aa.Length; j++){
                    Console.Write($"{aa[j]} ");
                }
                Console.WriteLine($"{aa[0]} {aa[1]}");
            }    
        }
    }
}