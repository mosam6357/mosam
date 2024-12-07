using System;

namespace q{
    class w{
        static void Main(String[] args){
            int t = int.Parse(Console.ReadLine());
            for (int i =0; i<t; i++){
                string[] aa = Console.ReadLine().Split();
                int a = int.Parse(aa[0]);
                for (int j=0; j<a; j++){
                    Console.Write(aa[1]);
                }
                Console.WriteLine();
            }
        }
    }
}