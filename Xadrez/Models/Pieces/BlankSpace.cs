using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Util;

namespace Xadrez.Models.Pieces
{
    public class BlankSpace : Piece
    {
        public BlankSpace(int line, int column, PiecesColors color) { }
        public BlankSpace(int column, int line)
        {
            Column = column;
            Line = line;
            Color = Util.PiecesColors.Null;
            Simbol = 'n';
        }
        public override bool CheckMovement(int newLine, int newColumn, Piece[,] pieces)
        {
           return false;
        }
    }
}
