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
            if ((this.Line - 1 == newLine) && (this.Column != newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }
            if ((this.Line + 1 == newLine) && (this.Column != newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }
            if ((this.Line == newLine) && (this.Column + 1 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }
            if ((this.Line == newLine) && (this.Column - 1 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }
            if ((this.Line - 1 == newLine) && (this.Column + 1 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }
            if ((this.Line - 1 == newLine) && (this.Column - 1 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }
            if ((this.Line + 1 == newLine) && (this.Column + 1 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }
            if ((this.Line + 1 == newLine) && (this.Column - 1 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
