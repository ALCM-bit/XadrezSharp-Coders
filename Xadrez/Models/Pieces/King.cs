using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Util;

namespace Xadrez.Models.Pieces
{
    public class King : Piece
    {
        public King(int line, int column, PiecesColors color) : base(column, line, color)
        {
            Simbol = 'K';
        }
        public override bool CheckMovement(int newLine, int newColumn, Piece[,] pieces)
        {
            throw new NotImplementedException();
        }
    }
}
