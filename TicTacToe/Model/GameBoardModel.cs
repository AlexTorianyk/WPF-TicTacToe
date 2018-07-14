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
        // I chose teh array to represent the GameBoard, because I think something like [2, 2] would be more intuitive, than 5.
        private IDictionary<int[], char> _gameBoard;
        public IDictionary<int[], char> GameBoard
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
            GameBoard = new Dictionary<int[], char>
            {
                { new int[] { 1, 1 }, 'E' },
                { new int[] { 1, 2 }, 'E' },
                { new int[] { 1, 3 }, 'E' },
                { new int[] { 2, 1 }, 'E' },
                { new int[] { 2, 2 }, 'E' },
                { new int[] { 2, 3 }, 'E' },
                { new int[] { 3, 1 }, 'E' },
                { new int[] { 3, 2 }, 'E' },
                { new int[] { 3, 3 }, 'E' }
            };
        }
    }
}
