namespace TicTacToe.Model.Interfaces
{
    public interface IGameBoardModel
    {
        void TakeTurn(int placement, char playerSymbol);
        void ResetGrid();
        IWinAndDrawCheck WinAndDrawChecker { get; }
    }
}
