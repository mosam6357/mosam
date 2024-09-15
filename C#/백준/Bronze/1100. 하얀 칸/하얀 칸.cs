using System;

namespace q{
    class w{
        static void Main(){
            int sum=0;
            for(int i=0; i<8; i++){
                string a = Console.ReadLine();
                for(int j=0; j<4; j++){
                    if(a[j*2+i%2]=='F'){
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}