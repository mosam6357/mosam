using System;

namespace q{
    class w{
        static void Main(){
            int a =  int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i=1;i<=a;i++){
                if(i<=99){
                    cnt++;
                }
                else{
                    String s = i.ToString();
                    int x = 0;
                    int ck = 0;
                    for (int j=0;j<s.Length-1;j++){
                        int t = s[j+1]-s[j];
                        if (j==0){
                            x=t;
                        }
                        else{
                            if(x!=t){
                                ck=1;
                                break;
                            }
                        }
                    }
                    if (ck==0)
                        cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}