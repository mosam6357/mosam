using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int cnt = 1;
            while(a!=1){
                if (a%2==0){
                    a/=2;
                }
                else{
                    a = a*3+1;
                }
                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}