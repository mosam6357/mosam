using System;

namespace q{
    class w{
        static void Main(){
            double a = double.Parse(Console.ReadLine());
            double n1 = a*0.78;
            double n2 = a*0.8+a*0.2*0.78;
            Console.WriteLine($"{n1} {n2}");
        }
    }
}