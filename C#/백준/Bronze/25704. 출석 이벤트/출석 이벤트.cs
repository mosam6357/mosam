using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int min = b;
            if(a>=5){
                min -= 500;
            }
            if(a>=10){
                min = min<b-b/10?min:b-b/10;
            }
            if(a>=15){
                min = min<b-2000?min:b-2000;
            }
            if(a>=20){
                min = min<b-b/4?min:b-b/4;
            }
            if(min<0){
                Console.WriteLine(0);
            }
            else{
                Console.WriteLine(min);
            }
        }
    }
}