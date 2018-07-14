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
        private IDictionary<int, char> _gameBoard;
        public IDictionary<int, char> GameBoard
        {
            get => _gameBoard;
            set { _gameBoard = value; OnPropertyChanged(); }
        }

        public GameBoardModel()
        {
            ResetGameBoard();
        }

        private void ResetGameBoard()
        {
            GameBoard = new Dictionary<int, char>
            {
                {1, 'E'},
                {2, 'E'},
                {3, 'E'},
                {4, 'E'},
                {5, 'E'},
                {6, 'E'},
                {7, 'E'},
                {8, 'E'},
                {9, 'E'}
            };
        }

        public void TakeTurn(int placement, char symbol)
        {
            GameBoard[placement] = symbol;
        }
    }
}
