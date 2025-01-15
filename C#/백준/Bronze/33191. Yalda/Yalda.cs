using System;

namespace q{
    class w{
        static void Main(){
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[3];
            for (int i=0;i<3;i++){
                a[i] = int.Parse(Console.ReadLine());
            }
            if (a[0]<=m){
                Console.WriteLine("Watermelon");
            }
            else if(a[1]<=m){
                Console.WriteLine("Pomegranates");
            }
            else if(a[2]<=m){
                Console.WriteLine("Nuts");
            }
            else{
                Console.WriteLine("Nothing");
            }
        }
    }
}