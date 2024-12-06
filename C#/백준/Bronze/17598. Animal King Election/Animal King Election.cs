using System;

namespace q{
    class w{
        static void Main(){
            int cnt=0;
            for (int i=0; i<9; i++){
                if(Console.ReadLine()=="Lion"){
                    cnt++;
                }
            }
            Console.WriteLine((cnt>=5)?"Lion":"Tiger");
        }
    }
}