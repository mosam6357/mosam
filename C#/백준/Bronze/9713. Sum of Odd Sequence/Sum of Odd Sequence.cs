using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                int n = (int.Parse(Console.ReadLine())+1)/2;
                Console.WriteLine(n*n);
            }
        }
    }
}