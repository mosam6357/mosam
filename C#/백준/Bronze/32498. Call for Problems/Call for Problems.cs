using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int cnt=0;
            for (int i =0; i<a; i++){
                int b = int.Parse(Console.ReadLine());
                if(b%2==1){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}