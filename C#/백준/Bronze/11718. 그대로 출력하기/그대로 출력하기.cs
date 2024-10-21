using System;
using System.Text;

namespace q{
    class w{
        static void Main(){
             StringBuilder sb = new StringBuilder();
                for(int i =0; i<100; i++){
                    string a = Console.ReadLine();
                    if(a==null){
                        break;
                    }
                    else{
                        sb.AppendLine(a);
                    }
                }
            Console.Write(sb.ToString());
        }
    }
}