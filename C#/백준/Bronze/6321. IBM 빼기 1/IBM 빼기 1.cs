using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for(int i =0; i<a; i++){
                Console.WriteLine($"String #{i+1}");
                String b = Console.ReadLine(); String c = "";
                for(int j =0; j<b.Length; j++){
                    int d = (int)b[j]+1;
                    if(d==91){
                        c+='A';
                    }
                    else{
                        c+=(char)d;
                    }
                }
                Console.WriteLine(c);
                if(i!=a-1){
                    Console.WriteLine();
                }
            }
        }
    }
}