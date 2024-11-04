using System;

namespace q{
    class w{
        static void Main(){
            String s = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i=0; i<a; i++){
                string b = Console.ReadLine();
                if(s.Equals(b)){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}