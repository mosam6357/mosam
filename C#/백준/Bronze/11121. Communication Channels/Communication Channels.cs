using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0; i<a; i++){
                String[] aa = Console.ReadLine().Split();
                if(aa[0].Equals(aa[1])){
                    Console.WriteLine("OK");
                }
                else{
                    Console.WriteLine("ERROR");
                }
            }
        }
    }
}