using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            while(a>b){
                b*=2;
            }
            if (a==b){
                Console.WriteLine(1);
            }
            else{
                Console.WriteLine(0);
            }
        }
    }
}