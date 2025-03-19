using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            String s = Console.ReadLine();
            int cnt = 0;
            for (int i=0;i<a;i++){
                if (s[i]=='2'){
                    cnt++;
                }
                else{
                    cnt--;
                }
            }
            if(cnt>0){
                Console.WriteLine("2");
            }
            else if (cnt==0){
                Console.WriteLine("yee");
            }
            else{
                Console.WriteLine("e");
            }
        }
    }
}