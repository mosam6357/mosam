using System;

namespace q{
    class w{
        static void Main(String[] args){
            while(true){
                int a = int.Parse(Console.ReadLine());
                if(a==0){
                    break;
                }
                for (int i =0; i<a; i++){
                    string s = "";
                    for (int j=0; j<i+1; j++){
                        s+="*";
                    }
                    Console.WriteLine(s);
                }
            }
        }
    }
}