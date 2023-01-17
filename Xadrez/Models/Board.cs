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
            PlacePawns();
            PlaceBishops();
            PlaceTowers();
            PlaceHorses();
            PlaceQueens();
            PlaceKings();
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

        public void PlacePawns() 
        {
            //White
            _board[1, 0] = new Pieces.Pawn(1, 0, Util.PiecesColors.White);
            _board[1, 1] = new Pieces.Pawn(1, 1, Util.PiecesColors.White);
            _board[1, 2] = new Pieces.Pawn(1, 2, Util.PiecesColors.White);
            _board[1, 3] = new Pieces.Pawn(1, 3, Util.PiecesColors.White);
            _board[1, 4] = new Pieces.Pawn(1, 4, Util.PiecesColors.White);
            _board[1, 5] = new Pieces.Pawn(1, 5, Util.PiecesColors.White);
            _board[1, 6] = new Pieces.Pawn(1, 6, Util.PiecesColors.White);
            _board[1, 7] = new Pieces.Pawn(1, 7, Util.PiecesColors.White);

            //black
            _board[6, 0] = new Pieces.Pawn(1, 0, Util.PiecesColors.Black);
            _board[6, 1] = new Pieces.Pawn(1, 1, Util.PiecesColors.Black);
            _board[6, 2] = new Pieces.Pawn(1, 2, Util.PiecesColors.Black);
            _board[6, 3] = new Pieces.Pawn(1, 3, Util.PiecesColors.Black);
            _board[6, 4] = new Pieces.Pawn(1, 4, Util.PiecesColors.Black);
            _board[6, 5] = new Pieces.Pawn(1, 5, Util.PiecesColors.Black);
            _board[6, 6] = new Pieces.Pawn(1, 6, Util.PiecesColors.Black);
            _board[6, 7] = new Pieces.Pawn(1, 7, Util.PiecesColors.Black);

        }
        public void PlaceTowers()
        {
            //White
            _board[0, 0] = new Pieces.Tower(0, 0, Util.PiecesColors.White);
            _board[0, 7] = new Pieces.Tower(0, 7, Util.PiecesColors.White);

            //Black
            _board[7, 0] = new Pieces.Tower(7, 0, Util.PiecesColors.Black);
            _board[7, 7] = new Pieces.Tower(3, 3, Util.PiecesColors.Black);
        }
        public void PlaceBishops()
        {
            //White
            _board[0, 2] = new Pieces.Bishop(0, 2, Util.PiecesColors.White);
            _board[0, 5] = new Pieces.Bishop(0, 5, Util.PiecesColors.White);

            //Black
            _board[7, 2] = new Pieces.Bishop(7, 2, Util.PiecesColors.Black);
            _board[7, 5] = new Pieces.Bishop(7, 5, Util.PiecesColors.Black);
        }
        public void PlaceHorses()
        {
            //White
            _board[0, 1] = new Pieces.Horse(0, 1, Util.PiecesColors.White);
            _board[0, 6] = new Pieces.Horse(0, 6, Util.PiecesColors.White);

            //Black
            _board[7, 1] = new Pieces.Horse(7, 1, Util.PiecesColors.Black);
            _board[7, 6] = new Pieces.Horse(7, 6, Util.PiecesColors.Black);
        }
        public void PlaceQueens() 
        {
            //White
            _board[0, 3] = new Pieces.Queen(0, 3, Util.PiecesColors.White);
            
            //Black
            _board[7, 3] = new Pieces.Queen(7, 3, Util.PiecesColors.Black);
            
        }
        public void PlaceKings()
        {
            //White
            _board[0, 4] = new Pieces.King(0, 4, Util.PiecesColors.White);

            //Black
            _board[7, 4] = new Pieces.King(7, 4, Util.PiecesColors.Black);
        }
    }
}
