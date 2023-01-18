using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Util;

namespace Xadrez.Models.Pieces
{
    public class Queen:Piece
    {
        public Queen(int line, int column, PiecesColors color) : base(line, column, color)
        {
            Simbol = 'Q';
        }

        public override bool CheckMovement(int newLine, int newColumn, Piece[,] pieces)
        {
            if (newLine != this.Line && newColumn == this.Column)
            {
                if (newLine > this.Line && newLine <= 7)
                {
                    for (int i = this.Line + 1; i < newLine - 1; i++)
                    {
                        if (pieces[i, newColumn].Simbol != '-')
                        {
                            return false;
                        }
                    }
                }
                if (newLine < this.Line && newLine >= 0)
                {
                    for (int i = this.Line - 1; i < newLine + 1; i++)
                    {
                        if (pieces[i, newColumn].Simbol != '-')
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
                    for (int i = this.Column - 1; i < newColumn + 1; i++)
                    {
                        if (pieces[this.Line, i].Simbol != '-')
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
            if ((newLine < 0 || newLine > 7) || (newColumn < 0 || newColumn > 7))
            {
                Console.WriteLine("Valores negativos ou acima de 7 não são aceitos como posições válidas");
                return false;
            }

            //Direita a cima
            if ((newLine != this.Line && newLine < this.Line) && (newColumn > this.Column))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }
            //Esquerda a cima
            if ((newLine != this.Line && newLine < this.Line) && (newColumn < this.Column))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }

            //Direita abaixo
            if ((newLine != this.Line && newLine > this.Line) && (newColumn > this.Column))
            {
                if (pieces[newLine, newColumn].Color != this.Color)
                {
                    return true;
                }
                return false;
            }

            //Esquerda abaixo
            if ((newLine != this.Line && newLine > this.Line) && (newColumn < this.Column))
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
