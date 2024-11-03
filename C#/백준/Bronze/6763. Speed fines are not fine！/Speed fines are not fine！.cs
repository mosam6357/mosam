using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(b<=a){
                Console.WriteLine("Congratulations, you are within the speed limit!");
            }
            else{
                int cost = 0;
                if(b-a<=20){
                    cost = 100;
                }
                else if(b-a<=30){
                    cost = 270;
                }
                else{
                    cost = 500;
                }
                Console.WriteLine($"You are speeding and your fine is ${cost}.");
            }
        }
    }
}