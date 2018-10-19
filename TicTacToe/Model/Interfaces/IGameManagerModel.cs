namespace TicTacToe.Model.Interfaces
{
    public interface IGameManagerModel
    {
        IPlayerModel CurrentPlayer { get; set; }
        void ResetGameData();
        IGameBoardModel GameBoard { get; set; }
    }
}