using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            int ck=0;
            for (int i=0; i<b.Length; i++){
                if(b[0]!=b[i]){
                    ck=1;
                    break;
                }
            }
            if(ck==0){
                Console.WriteLine("Yes");
            }
            else{
                Console.WriteLine("No");
            }
        }
    }
}