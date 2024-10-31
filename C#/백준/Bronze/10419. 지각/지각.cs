using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for(int i=0; i<a; i++){
                int b = int.Parse(Console.ReadLine());
                int j = 0;
                while(true){
                    int k = j+1;
                    if(k*k+k<=b){
                        j++;
                    }
                    else{
                        break;
                    }
                }
                Console.WriteLine(j);
            }
        }
    }
}