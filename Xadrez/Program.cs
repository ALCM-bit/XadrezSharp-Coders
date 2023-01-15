using System;
using Xadrez.Models;
using Xadrez.Models.Pieces;

namespace Xadez
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Board board = new Board();
            board.StartBoard();
            board.ShowBoard();

            //Pawn piece = new Pawn();
            //piece.Color = Xadrez.Util.PiecesColors.White;
            //Console.WriteLine(piece.Color);
            board.MovePiece(2, 0, board.SelectPiece(1,1));
            Console.ReadKey();
            board.MovePiece(6, 0, board.SelectPiece(7, 0));
            board.ShowBoard();
            Console.ReadKey();
        }
    }
}