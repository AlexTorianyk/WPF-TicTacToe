using System.Collections.ObjectModel;

namespace TicTacToe.Interfaces
{
    public interface IGameBoardModel
    {
        ObservableCollection<char> GameGrid { get; set; }
        void TakeTurn(int placement, char symbol);
        void ResetGrid();
        bool CheckWin();
        bool CheckDraw();
    }
}
