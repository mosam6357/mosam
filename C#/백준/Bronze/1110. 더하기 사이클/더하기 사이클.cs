using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = 0; int c = a;
            while(true){
                c=(c%10)*10+(c/10+c%10)%10;
                b++;
                if(a==c){
                    break;
                }
            }
            Console.WriteLine(b);
        }
    }
}