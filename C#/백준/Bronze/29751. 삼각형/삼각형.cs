using System;

namespace q{
    class w{
        static void Main(){
            string[] aa  = Console.ReadLine().Split();
            int a = int.Parse(aa[0]);
            int b = int.Parse(aa[1]);
            double c = a*b*0.5;
            string d = c.ToString("0.0");
            Console.WriteLine(d);
        }
    }
}