using System;
namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<9;i++){
                a -= int.Parse(Console.ReadLine());
            }
            Console.WriteLine(a);
        }
    }
}