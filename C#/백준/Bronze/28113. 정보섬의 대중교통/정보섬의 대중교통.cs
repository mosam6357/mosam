using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split(); int ck=1;
            int[] a = Array.ConvertAll(aa,int.Parse);
            if(a[0]>a[2]){
                ck=0;
            }
            if(a[1]==a[2] && ck==1){
                Console.Write("Anything");
            }
            else if(a[2]<a[1] && ck==1){
                Console.Write("Subway");
            }
            else{
                Console.Write("Bus");
            }
        }
    }
}