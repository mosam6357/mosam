using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int a = int.Parse(aa[0]);
            int b = int.Parse(aa[1]);
            if(a<b){
                Console.WriteLine(b-a);
            }
            else{
                Console.WriteLine(a+b);
            }
        }
    }
}