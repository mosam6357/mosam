using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            if(a%5==0){
                Console.WriteLine(a/5);
            }
            else{
                Console.WriteLine(a/5+1);
            }
        }
    }
}