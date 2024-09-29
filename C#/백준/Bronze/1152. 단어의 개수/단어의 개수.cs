using System;

namespace q{
    class w{
        static void Main(){
            string a = Console.ReadLine();
            char[] aa = a.ToCharArray();
            int no = 0;
            for(int i = 0; i<aa.Length; i++){
                if(aa[i]==' '){
                    if(i!=0 && i!=aa.Length-1){
                        no++;
                    }
                }
            }
            if(aa.Length ==1 && aa[0]==' '){
                Console.WriteLine(0);
            }
            else{
                Console.WriteLine(no+1);
            }
        }
    }
}