using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            while(true){
                String s = Console.ReadLine();
                if (s.Equals("=")){
                    Console.WriteLine(a);
                    break;
                }
                else{
                    int n = int.Parse(Console.ReadLine());
                    if (s.Equals("+")){
                        a+=n;
                    }
                    else if(s.Equals("-")){
                        a-=n;
                    }
                    else if(s.Equals("*")){
                        a*=n;
                    }
                    else{
                        a/=n;
                    }
                }
            }
        }
    }
}