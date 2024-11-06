using System;

namespace q{
    class w{
        static void Main(){
            String a = Console.ReadLine();
            int b = 0;
            int w = 0;
            for (int i =0; i<a.Length; i++){
                if(a[i]=='B'){
                    b++;
                }
                else{
                    w++;
                }
            }
            b/=2; w/=2;
            Console.WriteLine(b+w);
        }
    }
}