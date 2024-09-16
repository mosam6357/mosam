using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            string b = "WelcomeToSMUPC";
            if(a%14==0){
                Console.WriteLine("C");
            }
            else{
                Console.WriteLine(b[a%14-1]);
            }
        }
    }
}