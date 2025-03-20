using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            if(a%2!=0){
                a+=1;
            }
            if(a==2){
                a+=2;
            }
            Console.WriteLine(a);
        }
    }
}