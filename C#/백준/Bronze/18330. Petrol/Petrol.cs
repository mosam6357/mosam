using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine())+60;
            if(a>=b){
                Console.WriteLine((a-b)*3000+b*1500);
            }
            else{
                Console.WriteLine(a*1500);
            }
        }
    }
}