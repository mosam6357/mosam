using System;

namespace q{
    class w{
        static void Main(String[] args){
            while(true){
                int a = int.Parse(Console.ReadLine());
                if (a==0){
                    break;
                }
            int total = 0;
            for (int i=1;i<=a;i++){
                total += i*i;
            }
            Console.WriteLine(total);
            }
            
        }
    }
}