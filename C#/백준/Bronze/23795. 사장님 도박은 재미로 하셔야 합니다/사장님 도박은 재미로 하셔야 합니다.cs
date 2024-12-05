using System;

namespace q{
    class w{
        static void Main(){
            int sum = 0;
            while(true){
                int a = int.Parse(Console.ReadLine());
                if (a==-1){
                    break;
                }
                sum+=a;
            }
            Console.WriteLine(sum);
        }
    }
}