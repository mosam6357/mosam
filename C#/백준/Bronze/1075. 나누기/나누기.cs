using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = (a/100)*100;
            while(c%b!=0){
                c++;
            }
            if(c%100<10){
                Console.WriteLine($"0{c%100}");
            }
            else{
                Console.WriteLine(c%100);
            }
        }
    }
}