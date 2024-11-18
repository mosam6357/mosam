using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split('/'),int.Parse);
            if(a[0]<=12 && a[1]<=12){
                Console.WriteLine("either");
            }
            else if(a[0]>12){
                Console.WriteLine("EU");
            }
            else{
                Console.WriteLine("US");
            }
        }
    }
}