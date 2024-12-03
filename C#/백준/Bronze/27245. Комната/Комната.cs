using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = new int[2];
            for (int i=0; i<2; i++){
                aa[i] = int.Parse(Console.ReadLine());
            }
            int a = int.Parse(Console.ReadLine());
            if(aa.Min()>=a*2 && aa.Min()*2>=aa.Max()){
                Console.WriteLine("good");
            }
            else{
                Console.WriteLine("bad");
            }
        }
    }
}