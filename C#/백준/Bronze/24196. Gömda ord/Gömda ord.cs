using System;

namespace q{
    class w{
        static void Main(){
            string a = Console.ReadLine();
            int i =0;
            while(i<a.Length){
                Console.Write(a[i]);
                i+=(int)(a[i])-64;
            }
        }
    }
}