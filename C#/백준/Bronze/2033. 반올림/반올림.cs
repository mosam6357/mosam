using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int t = 10;
            int l = 1;
            while(a>t){
                if(a%t<=4*l){
                    a-=a%t;
                }
                else{
                    a=(a/t+1)*t;
                }
                t*=10;
                l*=10;
            }
            Console.WriteLine(a);
        }
    }
}