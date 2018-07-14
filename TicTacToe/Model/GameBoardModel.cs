using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Utilities;

namespace TicTacToe.Model
{
    public class GameBoardModel : PropertyChange, IGameBoardModel
    {
        private ObservableCollection<char> _gameGrid;
        public ObservableCollection<char> GameGrid
        {
            get => _gameGrid;
            set { _gameGrid = value; OnPropertyChanged(); }
        }

        public GameBoardModel()
        {
            ResetGrid();
        }

        private void ResetGrid()
        {
            GameGrid = new ObservableCollection<char> {'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E'};
        }

        public void TakeTurn(int placement, char symbol)
        {
            GameGrid[placement] = symbol;
        }
    }
}
