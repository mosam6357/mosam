using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            if(a%3==1){
                Console.WriteLine("U");
            }
            else if(a%3==2){
                Console.WriteLine("O");
            }
            else{
                Console.WriteLine("S");
            }
        }
    }
}