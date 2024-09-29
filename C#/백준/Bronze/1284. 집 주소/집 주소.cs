using System;

namespace q{
    class w{
        static void Main(){
            while(true){
                string a=Console.ReadLine();
                if(a=="0"){
                    break;
                }
                int len=1;
                for(int i =0; i<a.Length; i++){
                    if(a[i]=='0'){
                        len+=5;
                    }
                    else if(a[i]=='1'){
                        len+=3;
                    }
                    else{
                        len+=4;
                    }
                }
                Console.WriteLine(len);
            }
        }
    }
}