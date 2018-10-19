namespace TicTacToe.Model.Interfaces
{
    public interface IPlayerModel
    {
        string PlayerColor { get; set; }
        char PlayerSymbol { get; set; }
        int PlayerScore { get; set; }
    }
}
