using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if((a==1 || a==3) && (b==6 || b==8) && (c==2 || c==5)){
                Console.WriteLine("JAH");
            }
            else{
                Console.WriteLine("EI");
            }
        }
    }
}