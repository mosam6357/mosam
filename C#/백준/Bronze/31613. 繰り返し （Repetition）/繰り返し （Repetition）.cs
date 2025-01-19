using System;

namespace q{
    class w{
        static void Main(){
            int cnt = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while(a<b){
                if (a%3==0){
                    a++;
                }
                else if(a%3==1){
                    a*=2;
                }
                else{
                    a*=3;
                }
                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}