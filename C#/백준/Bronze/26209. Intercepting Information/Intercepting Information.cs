using System;

namespace q{
    class w{
        static void Main(){
            String[] a = Console.ReadLine().Split(); int cnt=0;
            for (int i =0; i<8; i++){
                if(a[i]=="9"){
                    cnt++;
                    break;
                }
            }
            if(cnt==0){
                Console.WriteLine('S');
            }
            else{
                Console.WriteLine('F');
            }
        }
    }
}