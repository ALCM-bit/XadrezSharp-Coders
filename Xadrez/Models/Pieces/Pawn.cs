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
        public bool FirstMove { get; set; }
        public Pawn(int line, int column, PiecesColors color) : base(line, column, color)
        {
            FirstMove = true;
            Simbol = 'P';
        }

        public override bool CheckMovement(int newLine, int newColumn, Piece[,] pieces)
        {

            if (this.Color == PiecesColors.White)
            {
                if ((this.Line +2 == newLine) && (this.FirstMove == true) && (this.Column == newColumn))
                {
                    if (pieces[newLine, newColumn].Color != PiecesColors.Null)
                    {
                        return false;
                    }
                    this.FirstMove = false;
                    return true;
                }
                if ((this.Line + 1 == newLine) && (this.Column == newColumn))
                {
                    if (pieces[newLine, newColumn].Color != PiecesColors.Null)
                    {
                        return false;
                    }
                    this.FirstMove = false;
                    return true;
                }
                //pegar peça a direita
                if ((this.Line + 1 == newLine) && (this.Column + 1 == newColumn))
                {
                    if (pieces[newLine, newColumn].Color != PiecesColors.White && pieces[newLine, newColumn].Color != PiecesColors.Null)
                    {
                        return true;
                    }
                    return false;
                }
                //pegar peça a direita
                if ((this.Line + 1 == newLine) && (this.Column - 1 == newColumn))
                {
                    if (pieces[newLine, newColumn].Color != PiecesColors.White && pieces[newLine, newColumn].Color != PiecesColors.Null)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            else if (this.Color == PiecesColors.Black)
            {
                if ((this.Line -2 == newLine)&&(this.FirstMove == true)&&(this.Column == newColumn))
                {
                    if (pieces[newLine, newColumn].Color != PiecesColors.Null)
                    {
                        return false;
                    }
                    this.FirstMove = false;
                    return true;
                }
                if ((this.Line - 1 == newLine) && (this.Column == newColumn))
                {
                    if (pieces[newLine, newColumn].Color != PiecesColors.Null)
                    {
                        return false;
                    }
                    this.FirstMove = false;
                    return true;
                }
                //pegar peça a direita
                if ((this.Line - 1 == newLine) && (this.Column + 1 == newColumn))
                {
                    if (pieces[newLine, newColumn].Color != PiecesColors.Black && pieces[newLine, newColumn].Color != PiecesColors.Null)
                    {
                        return true;
                    }
                    return false;
                }
                //pegar peça a direita
                if ((this.Line - 1 == newLine) && (this.Column - 1 == newColumn))
                {
                    if (pieces[newLine, newColumn].Color != PiecesColors.Black && pieces[newLine, newColumn].Color != PiecesColors.Null)
                    {
                        return true;
                    }
                    return false;
                }

                return false;
            }
            else
            {
                return false;
            }
            
        }

        
    }
}
