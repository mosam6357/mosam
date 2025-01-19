using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            long ans = 0;
            for (int i=0;i<a;i++){
                if (i==0){
                    ans = 5;
                }
                else{
                    ans+=(i+2)*3-2;
                }
            }
            Console.WriteLine(ans%45678);
        }
    }
}