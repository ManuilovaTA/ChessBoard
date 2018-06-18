using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class ChessBoard
    {
        int height, width;
        int result;
        public void BuildChessBoard(int h, int w)
        {
            height = h;
            width = w;

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write("* ");
                }
                if ((j % 2) == 0)
                {
                    Console.Write("\n" + " ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
           
        }

        public int Input()
        {
            Console.WriteLine("Enter Height & width: ");
            string parametr = Console.ReadLine();
            
            if(!int.TryParse(parametr, out result))
            {
                Console.WriteLine("Введен неправильный формат!");
                Input();
            }
            return result;
        }
    }
}
