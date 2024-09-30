using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int sum=0;
            while(true){
                string b = a.ToString();
                for (int i =0; i<b.Length; i++){
                    if(b[i]=='4' || b[i]=='7'){
                        sum++;
                    }
                }
                if(sum==b.Length){
                    Console.WriteLine(b);
                    break;
                }
                sum=0;
                a--;
            }
        }
    }
}