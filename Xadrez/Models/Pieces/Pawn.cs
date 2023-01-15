using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Models.Pieces
{
    public class Pawn : Piece
    {
        public override bool Movement(string position)
        {
            int line = int.Parse(position.Split(' ')[0]);
            int column = int.Parse(position.Split(' ')[1]);

            if (this.Color == Util.PiecesColors.White)
            {
                if (column != int.Parse(Position.Split(' ')[1]))
                {
                    if (column == int.Parse(Position.Split(' ')[1]) -1)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
    }
}
