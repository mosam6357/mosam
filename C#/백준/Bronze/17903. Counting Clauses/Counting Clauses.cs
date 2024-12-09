using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(aa[0]<8){
                Console.WriteLine("unsatisfactory");
            }
            else{
                Console.WriteLine("satisfactory");
            }
        }
    }
}