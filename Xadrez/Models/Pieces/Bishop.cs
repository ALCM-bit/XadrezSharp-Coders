using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Util;

namespace Xadrez.Models.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(int line, int column, PiecesColors color) : base(line, column, color)
        {
            Simbol = 'B';
        }
        public override bool CheckMovement(int newLine, int newColumn, Piece[,] pieces)
        {
            if ((newLine < 0|| newLine > 7)||(newColumn < 0 || newColumn > 7))
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
