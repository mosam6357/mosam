using System;

namespace q{
    class w{
        static void Main(){
            string a = Console.ReadLine();
            for (int i=0;i<a.Length;i+=10){
                if(a.Length-i<10){
                    Console.WriteLine(a.Substring(i));
                }
                else{
                    Console.WriteLine(a.Substring(i,10));
                }
            }
        }
    }
}