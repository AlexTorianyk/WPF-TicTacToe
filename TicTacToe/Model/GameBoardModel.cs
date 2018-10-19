using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TicTacToe.Model.Interfaces;
using TicTacToe.Utilities;

namespace TicTacToe.Model
{
    public class GameBoardModel : PropertyChange, IGameBoardModel
    {
        public IWinAndDrawCheck WinAndDrawChecker { get; set; }

        // i used an observable collection because it's much less trouble to represent something in the UI with it
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

        public void ResetGrid()
        {
            Task.Delay(300).ContinueWith(x =>
            {
                GameGrid = new ObservableCollection<char> {'E', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
                WinAndDrawChecker = new WinAndDrawCheck(GameGrid);
            });
        }

        // Simulates a player placing a symbol on the grid
        public void TakeTurn(int placement, char playerSymbol)
        {
            if (GameGrid[placement] == ' ')
            {
                GameGrid[placement] = playerSymbol;
            }
        }
    }
}
