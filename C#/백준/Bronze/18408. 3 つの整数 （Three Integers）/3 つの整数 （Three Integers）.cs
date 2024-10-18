using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(aa.Sum()>=5){
                Console.WriteLine(2);
            }
            else{
                Console.WriteLine(1);
            }
        }
    }
}