using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for(int i=0; i<a/5; i++){
                Console.Write('V');
            }
            for(int j=0; j<a%5; j++){
                Console.Write('I');
            }
        }
    }
}