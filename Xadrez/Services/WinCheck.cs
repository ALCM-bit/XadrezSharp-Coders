using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using Xadrez.Models;

namespace Xadrez.Services
{
    public class WinCheck
    {
        public static bool CheckKingsExistence(Piece[,] board)
        {
            int count = 0;
            foreach (var item in board)
            {
                if (item.Simbol == 'K')
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            return false;
        }
    }
}
