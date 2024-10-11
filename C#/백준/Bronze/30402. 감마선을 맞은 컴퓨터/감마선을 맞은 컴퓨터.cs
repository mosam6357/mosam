using System;

namespace q{
    class w{
        static void Main(){
            for (int i =0; i<15; i++){
                string a = Console.ReadLine();
                bool b1 = a.Contains("w");
                bool b2 = a.Contains("b");
                bool b3 = a.Contains("g");
                if (b1){
                    Console.WriteLine("chunbae");
                    break;
                }
                if(b2){
                    Console.WriteLine("nabi");
                    break;
                }
                if(b3){
                    Console.WriteLine("yeongcheol");
                    break;
                }
            }
        }
    }
}