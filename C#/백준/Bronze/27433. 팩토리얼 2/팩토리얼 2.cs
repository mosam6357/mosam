using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            long ans =1;
            for(int i =0; i<a; i++){
                ans*=i+1;
            }
            Console.WriteLine(ans);
        }
    }
}