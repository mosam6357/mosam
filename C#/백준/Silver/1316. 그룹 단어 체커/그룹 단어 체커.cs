using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int check=a;
            for(int i=0; i<a; i++){
                string x=Console.ReadLine();
                int l=x.Length;
                for(int j=0;j<l-1;j++){
                    if(x[j]!=x[j+1]){
                        if(x.Substring(j+1).Contains(x[j])){
                            check-=1;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(check);
        }
    }
}