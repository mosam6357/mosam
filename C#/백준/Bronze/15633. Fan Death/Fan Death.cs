using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i=1;i<=a;i++){
                if (a%i==0){
                    total+=i;
                }
            }
            Console.WriteLine(total*5-24);
        }
    }
}