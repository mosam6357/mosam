using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            string c ="";
            for (int i=0; i<a; i++){
                c+=b[b.Length-1-i];
            }
            for (int i =0; i<a; i++){
                if(b[i]=='?'){
                    if(c[i]=='?'){
                        Console.Write('a');
                    }
                    else{
                        Console.Write(c[i]);
                    }
                }
                else{
                    Console.Write(b[i]);
                }
            }
        }
    }
}