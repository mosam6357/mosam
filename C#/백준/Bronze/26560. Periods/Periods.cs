using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i =0; i<a; i++){
                string b = Console.ReadLine();
                if(b[b.Length-1]=='.'){
                    Console.WriteLine(b);
                }
                else{
                    Console.WriteLine(b+'.');
                }
            }
        }
    }
}