using System.Collections.ObjectModel;
using TicTacToe.Model;

namespace TicTacToe.Interfaces
{
    public interface IGameBoardModel
    {
        ObservableCollection<char> GameGrid { get; set; }
        void TakeTurn(int placement, char playerSymbol);
        void ResetGrid();
        WinAndDrawCheck WinAndDrawChecker { get; }
    }
}
