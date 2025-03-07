using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            while(true){
                int b = int.Parse(Console.ReadLine());
                if (b==0){
                    break;
                }
                if (b%a==0){
                    Console.WriteLine($"{b} is a multiple of {a}.");
                }
                else{
                    Console.WriteLine($"{b} is NOT a multiple of {a}.");
                }
            }
        }
    }
}