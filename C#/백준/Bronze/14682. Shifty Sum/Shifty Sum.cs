using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double total = a;
            for (int i=0;i<b;i++){
                total+=a*Math.Pow(10,b-i);
            }
            Console.WriteLine(total);
        }
    }
}