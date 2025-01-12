using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int m = 0;
            for (int i=0;i<a;i++){
                if (i%2==0){
                    m+=3;
                }
                else{
                    m-=2;
                }
            }
            Console.WriteLine(m);
        }
    }
}