using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Util;

namespace Xadrez.Models
{
    public abstract class Piece
    {
        public int Column { get; set; }
        public int Line { get; set; }
        public PiecesColors Color { get; set; }
        public char Simbol { get; set; }

        public Piece()
        {

        }
        public Piece(int line, int column, PiecesColors color)
        {
            this.Line = line;
            this.Column = column;
            this.Color = color;
        }
        public abstract bool CheckMovement(int newLine, int newColumn, Piece[,] pieces);
    }
}
