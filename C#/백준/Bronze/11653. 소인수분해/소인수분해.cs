using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            if(a!=1){
                for(int i =2; i<a+1;i++){
                    if(a%i == 0){
                        Console.WriteLine(i);
                        a=a/i;
                        i=1;
                    }
                }
            }
        }
    }
}