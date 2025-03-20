using System;
using System.Text;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i=0;i<5;i++){
                for (int j=0;j<a;j++){
                    if (i==0 || i==4){
                        for (int k=0;k<a*5;k++){
                            sb.Append("@");
                        }
                    }
                    else{
                        for (int k=0;k<a;k++){
                            sb.Append("@");
                        }
                    }
                    sb.AppendLine();
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}