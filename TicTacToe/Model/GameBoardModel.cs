using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Utilities;

namespace TicTacToe.Model
{
    public class GameBoardModel : PropertyChange, IGameBoardModel
    {
        private IDictionary<int[], char> _gameBoard;
        public IDictionary<int[], char> GameBoard
        {
            get => _gameBoard;
            set { _gameBoard = value; OnPropertyChanged(); }
        }
    }
}
