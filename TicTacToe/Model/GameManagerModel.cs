﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class GameManagerModel : IGameManagerModel
    {
        public IPlayerModel Player1 { get; set; }
        public IPlayerModel Player2 { get; set; }
        public IPlayerModel CurrentPlayer { get; set; }
        public IGameBoardModel GameGrid { get; set; }

        public GameManagerModel()
        {
            InitPlayers();
            GameGrid = new GameBoardModel();
        }

        private void InitPlayers()
        {
            Player1 = new PlayerModel('X', "Blue");
            Player2 = new PlayerModel('O', "Red");
        }
    }
}
