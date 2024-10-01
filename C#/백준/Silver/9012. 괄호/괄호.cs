using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i =0; i<a; i++){
                int b = 0;
                string c = Console.ReadLine();
                for (int j =0; j<c.Length; j++){
                    if(c[j]=='('){
                        b++;
                    }
                    else{
                        b--;
                        if(b==-1){
                            break;
                        }
                    }
                }
                if(b==0){
                    Console.WriteLine("YES");
                }
                else{
                    Console.WriteLine("NO");
                }
            }
        }
    }
}