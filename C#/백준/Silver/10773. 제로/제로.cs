using System;
using System.Collections.Generic;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int sum=0;
            Stack<int> stack = new Stack<int>();
            for (int i =0; i<a; i++){
                int b = int.Parse(Console.ReadLine());
                if (b==0){
                    stack.Pop();
                }
                else{
                    stack.Push(b);
                    }
                }
            foreach (int i in stack){
                sum+=i;
            }
            Console.WriteLine(sum);
        }
    }
}