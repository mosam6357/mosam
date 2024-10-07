using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            string[] aa = Console.ReadLine().Split();
            string b = Console.ReadLine();
            int cnt=0;
            for (int i=0; i<a; i++){
                if(aa[i]==b){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}