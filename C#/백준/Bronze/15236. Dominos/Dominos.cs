using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i=1;i<a+1;i++){
                total += i*(i+1)+(i*(i+1))/2;
            }
            Console.WriteLine(total);
        }
    }
}