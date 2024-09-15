using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine()); int b = 64; int cnt=0;
            while(a!=0){
                if(a>=b){
                    a-=b;
                    cnt++;
                }
                else{
                    b/=2;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}