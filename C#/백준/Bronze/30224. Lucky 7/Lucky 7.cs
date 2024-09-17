using System;

namespace q{
    class w{
        static void Main(){
            string a = Console.ReadLine(); int b = int.Parse(a);
            int ct = 0; int ch = 0;
            for(int i =0; i<a.Length; i++){
                if(a[i]=='7'){
                    ct++;
                    break;
                }
            }
            if(b%7==0){
                ch++;
            }
            if(ct+ch==0){
                Console.WriteLine(0);
            }
            else if(ct==0 && ch==1){
                Console.WriteLine(1);
            }
            else if(ct==1 && ch==0){
                Console.WriteLine(2);
            }
            else{
                Console.WriteLine(3);
            }
        }
    }
}