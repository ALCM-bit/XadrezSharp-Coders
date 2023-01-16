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
            //board.MovePiece(board.SelectPiece(1,1));
            //Console.ReadKey();
            Console.Write("Digite a Linha: ");
            int Line = int.Parse(Console.ReadLine());
            Console.Write("Digite a Coluna: ");
            int Column = int.Parse(Console.ReadLine());
            board.MovePiece(Line, Column,board.SelectPiece(Line, Column));
            board.ShowBoard();
            Console.ReadKey();
        }
    }
}