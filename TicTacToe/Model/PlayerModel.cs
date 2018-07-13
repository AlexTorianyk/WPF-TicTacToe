using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Utilities;

namespace TicTacToe.Model
{
    public class PlayerModel : PropertyChange
    {
        private string _playerColor;
        private string _playerSymbol;
        private int _playerScore = 0;

        public string PlayerColor { get => _playerColor; set => _playerColor = value; }
        public string PlayerSymbol { get => _playerSymbol; set => _playerSymbol = value; }
        public int PlayerScore
        {
            get => _playerScore;
            set { _playerScore = value; OnPropertyChanged(); }
        }
    }
}
