using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int time = (a[0]-11)*1440+(a[1]-11)*60+(a[2]-11);
            if(time<0){
                Console.WriteLine(-1);
            }
            else{
                Console.WriteLine(time);
            }
        }
    }
}