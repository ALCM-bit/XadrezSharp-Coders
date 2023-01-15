using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Util;

namespace Xadrez.Models.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(int column, int Line, PiecesColors color) : base(column, Line, color)
        {
            Simbol = 'P';
        }

        public override bool CheckMovement(int newLine, int newColumn, Piece[,] pieces)
        {

            if (this.Color == Util.PiecesColors.White)
            {
                if (pieces[newLine + 1, newColumn] != null && pieces[newLine + 1, newColumn].Simbol != 'n')
                {
                    return false;
                }
                return true;

            }
            else if (this.Color == Util.PiecesColors.Black)
            {
                if (pieces[newLine - 1, newColumn] != null && pieces[newLine + 1, newColumn].Simbol != 'n')
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }

        
    }
}
