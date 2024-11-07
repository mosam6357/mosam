using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(a[0]>=1000 && (a[1]>=8000 || a[2]>=260)){
                Console.WriteLine("Very Good");
            }
            else if(a[0]>=1000){
                Console.WriteLine("Good");
            }
            else{
                Console.WriteLine("Bad");
            }
        }
    }
}