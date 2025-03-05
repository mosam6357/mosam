using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                double cost = double.Parse(Console.ReadLine())*8.0/10.0;
                Console.WriteLine($"${Math.Round(cost,2):F2}");
            }
        }
    }
}