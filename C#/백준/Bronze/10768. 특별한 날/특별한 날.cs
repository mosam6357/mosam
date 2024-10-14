using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(a==1 || (a==2 && b<18)){
                Console.WriteLine("Before");
            }
            else if(a==2 && b==18){
                Console.WriteLine("Special");
            }
            else{
                Console.WriteLine("After");
            }
        }
    }
}