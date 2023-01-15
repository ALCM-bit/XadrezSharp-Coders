using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Models
{
    public class Board
    {
        private char[,] _board = new char[8,8];

        public void StartBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    _board[i, j] = 'X';
                }
            }
        }
        public void ShowBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"|{_board[i,j]}|");
                }
              Console.WriteLine();
            }
        }
    }
}
