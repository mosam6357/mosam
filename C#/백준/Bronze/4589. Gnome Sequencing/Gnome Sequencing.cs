using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Gnomes:");
            for (int i = 0; i<a; i++){
                String[] aaa  = Console.ReadLine().Split();
                int[] aa = Array.ConvertAll(aaa,int.Parse);
                if((aa[0]<aa[1] && aa[1]<aa[2])||(aa[0]>aa[1] && aa[1]>aa[2])){
                    Console.WriteLine("Ordered");
                }
                else{
                    Console.WriteLine("Unordered");
                }
            }
        }
    }
}