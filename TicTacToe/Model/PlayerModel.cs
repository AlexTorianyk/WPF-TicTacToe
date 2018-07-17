﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Utilities;

namespace TicTacToe.Model
{
    public class PlayerModel : PropertyChange, IPlayerModel
    {
        private string _playerColor;
        private char _playerSymbol;
        private int _playerScore = 0;

        public char PlayerSymbol { get => _playerSymbol; set => _playerSymbol = value; }
        public string PlayerColor
        {
            get => _playerColor;
            set { _playerColor = value; OnPropertyChanged(); }
        }
        public int PlayerScore
        {
            get => _playerScore;
            set { _playerScore = value; OnPropertyChanged(); }
        }

        public PlayerModel(char playerSymbol, string playerColor)
        {
            PlayerSymbol = playerSymbol;
            PlayerColor = playerColor;
        }
    }
}
