using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string s2 = "";
            for (int i=0;i<a;i++){
                if(s[i]=='J'){
                    s2+='O';
                }
                else if(s[i]=='O'){
                    s2+='I';
                }
                else{
                    s2+='J';
                }
            }
            Console.WriteLine(s2);
        }
    }
}