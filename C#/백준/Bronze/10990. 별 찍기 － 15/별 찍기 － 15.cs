using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                for (int j=0;j<a-i-1;j++){
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j=0;j<i*2-1;j++){
                    Console.Write(" ");
                }
                if (i!=0){
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}