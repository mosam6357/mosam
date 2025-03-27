using System;

namespace q{
    class w{
        static void Main(String[] args){
            int i = 1;
            while(true){
                double a = double.Parse(Console.ReadLine());
                if (a==0){
                    break;
                }
                Console.WriteLine($"File #{i}");
                Console.WriteLine($"John needs {Math.Ceiling(a/2480000)} floppies.\n");
                i++;
            }
        }
    }
}