using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0; i<a; i++){
                int b = int.Parse(Console.ReadLine());
                int c = b%100;
                if((b+1)%c==0){
                    Console.WriteLine("Good");
                }
                else{
                    Console.WriteLine("Bye");
                }
            }
        }
    }
}