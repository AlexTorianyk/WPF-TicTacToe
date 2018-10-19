namespace TicTacToe.Model.Interfaces
{
    public interface IGameBoardModel
    {
        void ResetGrid();
        void TakeTurn(int placement, char playerSymbol);
        IWinAndDrawCheck WinAndDrawChecker { get; }
    }
}
