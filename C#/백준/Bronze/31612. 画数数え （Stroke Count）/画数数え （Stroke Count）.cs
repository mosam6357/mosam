using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            int cnt=0;
            for (int i =0; i<a; i++){
                if(b[i]=='o'){
                    cnt++;
                }
                else{
                    cnt+=2;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}