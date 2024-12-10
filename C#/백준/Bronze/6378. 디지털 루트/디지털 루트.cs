using System;

namespace q{
    class w{
        static int dsum(string a){
            int sum = 0;
            for (int i=0; i<a.Length; i++){
                sum+=int.Parse(a[i].ToString());
            }
            if(sum>=10){
                return dsum(sum.ToString());
            }
            else{
                return sum;
            }
        }
        static void Main(){
            while(true){
                string a = Console.ReadLine();
                if(a[0]=='0'){
                    break;
                }
                Console.WriteLine(dsum(a));
            }
        }
    }
}