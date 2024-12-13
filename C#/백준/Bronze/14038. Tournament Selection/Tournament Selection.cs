using System;

namespace q{
    class w{
        static void Main(){
            int cnt=0;
            for(int i=0; i<6; i++){
                string a = Console.ReadLine();
                if(a[0]=='W'){
                    cnt++;
                }
            }
            Console.WriteLine($"{((cnt==0)?-1:(8-cnt)/2)}");
        }
    }
}