using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = {1,1,2,6,4};
            for (int i=0; i<a; i++){
                int b = int.Parse(Console.ReadLine());
                if(b>4){
                    Console.WriteLine(0);
                }
                else{
                    Console.WriteLine(aa[b]);
                }
            }
        }
    }
}