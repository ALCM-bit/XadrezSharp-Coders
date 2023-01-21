using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Models;
using Xadrez.Services.JsonSystem;

namespace Xadrez.Services
{
    public class PlayersLogin
    {
        public static void AddNewPlayers(Player player)
        {
            List<Player> list = new List<Player>();
            list = JsonReadWrite.JsonReader();
            
            list.Add(player);
            JsonReadWrite.JsonWriter(list);
        }

    }
}
