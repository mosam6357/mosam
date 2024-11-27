using System;

namespace q{
    class w{
        static void Main(){
            string a = Console.ReadLine();
            string s = "";
            for (int i=0; i<a.Length; i++){
                char c = (char)((int)a[i]-32);
                s+=c;
                if(s.Length==1000){
                    Console.Write(s);
                    s="";
                }
            }
            Console.WriteLine(s);
        }
    }
}