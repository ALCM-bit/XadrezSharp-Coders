using System;
using Xadrez.Models;

namespace Xadez
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Board board = new Board();
            board.StartBoard();
            board.ShowBoard();

            Piece piece = new Piece();
            piece.Color = Xadrez.Util.PiecesColors.White;
            Console.WriteLine(piece.Color);
        }
    }
}