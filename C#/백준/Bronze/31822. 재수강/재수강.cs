using System;

namespace q{
    class w{
        static void Main(){
            string q = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int cnt=0;
            for (int i=0; i<a; i++){
                string b = Console.ReadLine();
                for (int j =0; j<5; j++){
                    if(q[j]!=b[j]){
                        break;
                    }
                    if(j==4){
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}