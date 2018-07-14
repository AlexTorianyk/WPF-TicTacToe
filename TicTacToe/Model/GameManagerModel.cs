using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class GameManagerModel : IGameManagerModel
    {
        public PlayerModel Player1 { get; set; }
        public PlayerModel Player2 { get; set; }
        //some board class with the array/dictionary


        public GameManagerModel()
        {
            InitPlayers();
            
        }

        private void InitPlayers()
        {
            Player1 = new PlayerModel('X', "Blue");
            Player2 = new PlayerModel('O', "Red");
        }
    }
}
