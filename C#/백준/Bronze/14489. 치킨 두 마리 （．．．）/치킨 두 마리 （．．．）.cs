using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int c = int.Parse(Console.ReadLine());
            if(aa[0]+aa[1]<c*2){
                Console.WriteLine(aa.Sum());
            }
            else{
                Console.WriteLine(aa.Sum()-c*2);
            }
        }
    }
}