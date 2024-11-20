using System;

namespace q{
    class w{
        static void Main(){
            int[] a = new int[4];
            for (int i=0; i<4; i++){
                a[i] = int.Parse(Console.ReadLine());
            }
            if(a.Max()==a.Min()){
                Console.WriteLine("Fish At Constant Depth");
            }
            else if(a[0]<a[1] && a[1]<a[2] && a[2]<a[3]){
                Console.WriteLine("Fish Rising");
            }
            else if(a[0]>a[1] && a[1]>a[2] && a[2]>a[3]){
                Console.WriteLine("Fish Diving");
            }
            else{
                Console.WriteLine("No Fish");
            }
        }
    }
}