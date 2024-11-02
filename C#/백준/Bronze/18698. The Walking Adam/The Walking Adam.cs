using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i =0; i<a; i++){
                string b = Console.ReadLine();
                int walk = 0;
                for (int j =0; j<b.Length; j++){
                    if(b[j]=='U'){
                        walk++;
                    }
                    else{
                        break;
                    }
                }
                Console.WriteLine(walk);
            }
        }
    }
}