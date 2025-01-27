using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int s = 0;
            if (a%2==1){
                Console.WriteLine("still running");
            }
            else{
                for (int i=0;i<a/2;i++){
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());
                    s+=c-b;
                }
                Console.WriteLine(s);
            }
        }
    }
}