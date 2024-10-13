using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int ck=0;
            int cnt1=0;
            int cnt2=0;
            String[] b = new String[a];
            for (int i=0; i<a; i++){
                b[i] = Console.ReadLine();
                ck=0;
                for(int j =0; j<a-1; j++){
                    if(b[i][j] == b[i][j+1] && b[i][j]=='.' && ck==0){
                        cnt1++;
                        ck++;
                    }
                    else if(b[i][j]=='X'){
                        ck=0;
                    }
                }
            }
            for(int i=0; i<a; i++){
                ck=0;
                for (int j=0; j<a-1; j++){
                    if(b[j][i] == b[j+1][i] && b[j][i]=='.' && ck==0){
                        cnt2++;
                        ck++;
                    }
                    else if(b[j][i]=='X'){
                        ck=0;
                    }
                }
            }
            Console.WriteLine($"{cnt1} {cnt2}");
        }
    }
}