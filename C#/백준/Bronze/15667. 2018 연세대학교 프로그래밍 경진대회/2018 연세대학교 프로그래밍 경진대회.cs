using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=1;i<=100;i++){
                if (a==1+i+i*i){
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}