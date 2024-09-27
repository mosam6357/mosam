using System;

namespace q{
    class w{
        static void Main(){
            int a=int.Parse(Console.ReadLine()); int i=1; int sum=0;
            while(true){
                string b = i.ToString();
                if(b.Contains("666")){
                    sum++;
                    if(sum==a){
                        Console.WriteLine(i);
                        break;
                    }
                }
                i++;
            }
        }
    }
}