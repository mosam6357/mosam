using System;

namespace q{
    class w{
        static void Main(){
            int a=0;
            string[] aa = {"N","E","S","W"};
            for (int i =0; i<10; i++){
                a+=int.Parse(Console.ReadLine());
            }
            Console.WriteLine(aa[a%4]);
        }
    }
}