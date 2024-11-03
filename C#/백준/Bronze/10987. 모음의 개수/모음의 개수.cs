using System;

namespace q{
    class w{
        static void Main(){
            string a = Console.ReadLine();
            string b = "aieou";
            int cnt = 0;
            for (int i=0; i<a.Length; i++){
                for (int j =0; j<5; j++){
                    if(a[i]==b[j]){
                        cnt++;
                        break;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}