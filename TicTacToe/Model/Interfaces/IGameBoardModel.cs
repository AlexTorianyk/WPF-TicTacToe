namespace TicTacToe.Model.Interfaces
{
    public interface IGameBoardModel
    {
        void ResetGrid();
        void TakeTurn(int placement, char playerSymbol);
        bool CheckWin();
        bool CheckDraw();
    }
}
