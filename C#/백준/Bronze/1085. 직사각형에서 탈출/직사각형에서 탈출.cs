using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int[] a = new int[4];
            for(int i =0; i<4; i++){
                a[i] = int.Parse(aa[i]);
            }
            int min = 2000;
            if(min>a[0]){
                min = a[0];
            }
            if(min>a[1]){
                min = a[1];
            }
            if(min>a[2]-a[0]){
                min = a[2]-a[0];
            }
            if(min>a[3]-a[1]){
                min = a[3]-a[1];
            }
            Console.WriteLine(min);
        }
    }
}