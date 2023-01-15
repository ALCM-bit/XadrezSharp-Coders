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
        public Tower(int column, int Line, PiecesColors color) : base(column, Line, color)
        {
            Simbol = 'T';
        }
        public override bool CheckMovement(int newLine, int newColumn, Piece[,] pieces)
        {
            if (this.Color == PiecesColors.White)
            {
                if (pieces[newLine, newColumn].Line == newLine)
                {
                    for (int i = 0; i < newLine - 1; i++)
                    {
                        if (pieces[this.Line, i].Simbol != 'n')
                        {
                            return false;
                        }
                    }
                    if (pieces[newLine, newColumn].Color != this.Color)
                    {
                        return true;
                    }
                    return false;
                }
                if (pieces[newLine, newColumn].Column == newColumn)
                {
                    for (int i = 0; i < newColumn - 1; i++)
                    {
                        if (pieces[this.Line, i].Simbol != 'n')
                        {
                            return false;
                        }
                    }
                    if (pieces[newLine, newColumn].Color != this.Color)
                    {
                        return true;
                    }

                }

            }
            if (this.Color == PiecesColors.Black)
            {
                if (pieces[newLine, newColumn].Line == newLine)
                {
                    for (int i = 0; i < newLine + 1; i++)
                    {
                        if (pieces[this.Line, i].Simbol != 'n')
                        {
                            return false;
                        }
                    }
                    if (pieces[newLine, newColumn].Color != this.Color)
                    {
                        return true;
                    }
                    return false;
                }
                if (pieces[newLine, newColumn].Column == newColumn)
                {
                    for (int i = 0; i < newColumn + 1; i++)
                    {
                        if (pieces[this.Line, i].Simbol != 'n')
                        {
                            return false;
                        }
                    }
                    if (pieces[newLine, newColumn].Color != this.Color)
                    {
                        return true;
                    }

                }

            }

            return false;
        }
    }
}
