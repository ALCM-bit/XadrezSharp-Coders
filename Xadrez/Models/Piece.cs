using System;
using System.Collections.Generic;
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

        public abstract bool Movement(int newColumn, int newLine);
    }
}
