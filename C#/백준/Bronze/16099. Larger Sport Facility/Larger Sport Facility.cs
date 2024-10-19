using System;

namespace q{
    class w{
        static void Main(){
            int q = int.Parse(Console.ReadLine());
            for (int i =0; i<q; i++){
            long[] a = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
            if(a[0]*a[1]>a[2]*a[3]){
                Console.WriteLine("TelecomParisTech");
            }
            else if(a[0]*a[1]==a[2]*a[3]){
                Console.WriteLine("Tie");
            }
            else{
                Console.WriteLine("Eurecom");
            }
            }
        }
    }
}