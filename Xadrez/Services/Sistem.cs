using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xadrez.Models;

namespace Xadrez.Services
{
    public class Sistem
    {
        public static void StartCheesGame()
        {
            Console.Write("Digite o nome do Jogador 1: ");
            string name1 = Console.ReadLine();
            Console.Write("Digite o nome do Jogador 2: ");
            string name2 = Console.ReadLine();
            Board board = new Board(name1, name2);
            board.StartBoard();
            int option = 1;
            while (option !=0)
            {
                board.ShowBoard();
                Console.WriteLine($"Vez do: {board.ShowPlayer()}");
                Console.Write("Digite a Linha: ");
                int Line = int.Parse(Console.ReadLine());
                Console.Write("Digite a Coluna: ");
                int Column = int.Parse(Console.ReadLine());
                board.MovePiece(Line, Column, board.SelectPiece(Line, Column));
                board.ShowBoard();
            }
            
            
        }
    }
}
