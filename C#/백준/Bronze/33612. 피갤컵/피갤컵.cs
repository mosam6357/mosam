using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int t = 24289+a*7;
            if (t%12==0){
                Console.WriteLine($"{t/12-1} 12");
            }
            else{
                Console.WriteLine($"{t/12} {t%12}");
            }
        }
    }
}