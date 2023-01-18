using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Models
{
    public class Player
    {
        public string Nome { get; set; }
        public int Points { get; set; }

        public Player(string nome) 
        { 
            Nome = nome;
        }
    }
}
