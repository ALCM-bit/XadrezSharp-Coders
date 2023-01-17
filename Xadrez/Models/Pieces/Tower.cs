using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Util;

namespace Xadrez.Models.Pieces
{
    public class Tower : Piece
    {
        public Tower(int line, int column, PiecesColors color) : base(line, column, color)
        {
            Simbol = 'T';
        }
        public override bool CheckMovement(int newLine, int newColumn, Piece[,] pieces)
        {
            if (newLine != this.Line && newColumn == this.Column)
            {
                if (newLine > this.Line && newLine <= 7)
                {
                    for (int i = this.Line + 1; i < newLine - 1; i++)
                    {
                        if (pieces[i, newColumn].Simbol != 'n')
                        {
                            return false;
                        }
                    }
                }
                if (newLine < this.Line && newLine >= 0)
                {
                    for (int i = this.Line -1; i < newLine + 1; i++)
                    {
                        if (pieces[i, newColumn].Simbol != 'n')
                        {
                            return false;
                        }
                    }
                }      
                if (pieces[newLine, newColumn].Color != this.Color || pieces[newLine, newColumn].Color == PiecesColors.Null)
                {
                    return true;
                }
                return false;
            }
            else if (this.Line == newLine && this.Column != newColumn)
            {
                if (newColumn > this.Column && newColumn <= 7)
                {
                    for (int i = this.Column + 1; i < newColumn - 1; i++)
                    {
                        if (pieces[this.Line, i].Color != PiecesColors.Null)
                        {
                            return false;
                        }
                    }
                }
                if (newColumn < this.Column && newColumn >= 0)
                {
                    for (int i = this.Column -1; i < newColumn + 1; i++)
                    {
                        if (pieces[this.Line, i].Simbol != 'n')
                        {
                            return false;
                        }
                    }
                }
                if (pieces[newLine, newColumn].Color != this.Color || pieces[newLine, newColumn].Color == PiecesColors.Null)
                {
                    return true;
                }
                return false;
            }
            return false;

        }


    }
}

