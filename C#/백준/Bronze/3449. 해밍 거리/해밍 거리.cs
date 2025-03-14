using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                int cnt = 0;
                for (int j=0;j<x.Length;j++){
                    if (x[j]!=y[j]){
                        cnt++;
                    }
                }
                Console.WriteLine($"Hamming distance is {cnt}.");
            }
        }
    }
}