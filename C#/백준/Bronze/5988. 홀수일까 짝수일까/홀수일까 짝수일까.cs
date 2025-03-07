using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                String b = Console.ReadLine();
                if ((int)b[b.Length-1]%2==0){
                    Console.WriteLine("even");
                }
                else{
                    Console.WriteLine("odd");
                }
            }
        }
    }
}