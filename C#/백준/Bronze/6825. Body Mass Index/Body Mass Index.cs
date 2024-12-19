using System;

namespace q{
    class w{
        static void Main(){
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float bmi = a/(b*b);
            if(bmi<18.5){
                Console.WriteLine("Underweight");
            }
            else if(bmi>25){
                Console.WriteLine("Overweight");
            }
            else{
                Console.WriteLine("Normal weight");
            }
        }
    }
}