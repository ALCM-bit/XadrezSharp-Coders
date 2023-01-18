using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Util;

namespace Xadrez.Models.Pieces
{
    public class Horse : Piece
    {
        public Horse(int line, int column, PiecesColors color) : base(line,column, color)
        {
            Simbol = 'H';
        }
        public override bool CheckMovement(int newLine, int newColumn, Piece[,] pieces)
        {
            if ((newLine < 0 || newLine > 7) || (newColumn < 0 || newColumn > 7))
                return false;
            //L para cima a direita
            if ((this.Line -2 == newLine) && (this.Column +1 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;

            }
            //L para cima a esquerda
            if ((this.Line -2 == newLine)&&(this.Column -1 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }

            // L para baixo a direita
            if ((this.Line + 2 == newLine) && (this.Column + 1 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }
            //L para baixo a esquerda
            if ((this.Line + 2 == newLine) && (this.Column - 1 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }

            // L horizontal para direita acima
            if ((this.Line -1 == newLine) && (this.Column +2 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }
            // L horizontal para direita abaixo
            if ((this.Line +1 == newLine) && (this.Column + 2 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }

            // L horizontal para esquerda acima
            if ((this.Line -1 == newLine) && (this.Column -2 == newColumn))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }

            // L horizontal para esquerda abaixo
            if ((this.Line + 1 == newLine) && (this.Column - 2 == newColumn))
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
