using System;

namespace q{
    class w{
        static void Main(String[] args){
            while(true){
                String[] aa = Console.ReadLine().Split();
                int a = int.Parse(aa[0]);
                String s = aa[1];
                int b = int.Parse(aa[2]);
                if (a==0 && s=="W" && b==0){
                    break;
                }
                if (s=="W"){
                    if (a-b<-200){
                        Console.WriteLine("Not allowed");
                    }
                    else{
                        Console.WriteLine(a-b);
                    }
                }
                else{
                    Console.WriteLine(a+b);
                }
            }
        }
    }
}