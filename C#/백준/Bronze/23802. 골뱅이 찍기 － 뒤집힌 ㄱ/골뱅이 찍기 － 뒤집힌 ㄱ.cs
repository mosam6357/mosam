using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<5;i++){
                for (int j=0;j<a;j++){
                    if (i==0){
                        for (int k=0;k<a*5;k++){
                            Console.Write('@');
                        }
                    }
                    else{
                        for (int k=0;k<a;k++){
                            Console.Write('@');
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}