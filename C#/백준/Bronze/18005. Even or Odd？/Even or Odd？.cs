using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            if (a%2==0){
                int b = a/2;
                if (b%2==0){
                    Console.WriteLine("2");
                }
                else{
                    Console.WriteLine("1");
                }
            }
            else{
                Console.WriteLine("0");
            }
        }
    }
}