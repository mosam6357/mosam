using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i= 0; i<a; i++){
                int b = int.Parse(Console.ReadLine());
                for (int j=0; j<b;j++){
                    Console.Write('=');
                }
                Console.WriteLine();
            }
        }
    }
}