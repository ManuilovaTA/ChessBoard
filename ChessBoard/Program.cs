using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard chB = new ChessBoard();

            Console.WriteLine("Enter Height: ");
            int h = chB.Input();

            Console.WriteLine("Enter width: ");
            int w = chB.Input();

            chB.BuildChessBoard(h, w);

            Console.ReadKey();
        }
    }
}
