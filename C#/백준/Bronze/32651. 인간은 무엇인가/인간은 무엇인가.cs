using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            if(a%2024==0 && a<100000){
                Console.WriteLine("Yes");
            }
            else{
                Console.WriteLine("No");
            }
        }
    }
}