using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xadrez.Models.Pieces;


namespace Xadrez.Models
{
    public class Board
    {
        private Piece[,] _board = new Piece[8,8];

        public void StartBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    _board[i, j] = new BlankSpace(j,i);
                }
            }
            _board[0, 1] = new Pieces.Pawn(1, 0, Util.PiecesColors.White);
            _board[1, 1] = new Pieces.Pawn(1, 1, Util.PiecesColors.White);
            _board[2, 0] = new Pieces.Tower(2, 0, Util.PiecesColors.White);

            _board[7, 0] = new Pieces.Pawn(7, 0, Util.PiecesColors.Black);
            _board[6, 0] = new Pieces.Pawn(6, 0, Util.PiecesColors.Black);
            _board[3, 3] = new Pieces.Bishop(3, 3, Util.PiecesColors.Black);
        }
        public void ShowBoard()
        {
            Console.Clear();
            Console.WriteLine("  0  1  2  3  4  5  6  7");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{i}");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"|{_board[i,j].Simbol}|");
                }
              Console.WriteLine();
            }
            Console.ReadKey();
        }
        public Piece SelectPiece(int line, int column)
        {

            Console.Write("Digite a Linha do destino: ");
            int newLine = int.Parse(Console.ReadLine());
            Console.Write("Digite a Coluna do destino: ");
            int newColumn = int.Parse(Console.ReadLine());

            if (_board[line, column].CheckMovement(newLine, newColumn, _board) == false)
            {
                Console.WriteLine("Peça inválida");
                return null;
            }
            else
            {
                _board[line, column].Line = newLine;
                _board[line, column].Column = newColumn;
                return _board[line, column];
            }
        }

        public void MovePiece(int line, int column, Piece piece)
        {
            if (piece != null)
            {
                _board[line, column] = new BlankSpace(line, column);
                _board[piece.Line, piece.Column] = piece;
            }
            
        }

    }
}
