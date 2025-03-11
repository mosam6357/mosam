using System;

namespace q{
    class w{
        static void Main(String[] args){
            while(true){
                int a = int.Parse(Console.ReadLine());
                if (a==0){
                    break;
                }
                Console.WriteLine($"{a} => {a*a-(a-1)}");
            }
        }
    }
}