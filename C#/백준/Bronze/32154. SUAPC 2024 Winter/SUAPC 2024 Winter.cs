using System;

namespace q{
    class w{
        static void Main(){
            string[,] board = {{"11", "A B C D E F G H J L M"},
                    {"9", "A C E F G H I L M"},
                    {"9", "A C E F G H I L M"},
                    {"9", "A B C E F G H L M"},
                    {"8", "A C E F G H L M"},
                    {"8", "A C E F G H L M"},
                    {"8", "A C E F G H L M"},
                    {"8", "A C E F G H L M"},
                    {"8", "A C E F G H L M"},
                    {"8", "A B C F G H L M"}};
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(board[a-1,0]);
            Console.WriteLine(board[a-1,1]);
        }
    }
}