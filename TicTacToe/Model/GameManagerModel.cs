using Prism.Events;
using TicTacToe.Interfaces;
using TicTacToe.Utilities;
using TicTacToe.Utilities.Events;

namespace TicTacToe.Model
{
    public class GameManagerModel : PropertyChange, IGameManagerModel
    {
        #region Variables and Fields
        private bool _gameOver;
        public bool GameOver
        {
            get => _gameOver;
            set { _gameOver = value; OnPropertyChanged(); }
        }
        
        public IPlayerModel Player1 { get; set; }
        public IPlayerModel Player2 { get; set; }
        private IPlayerModel _currentPlayer;
        public IPlayerModel CurrentPlayer
        {
            get => _currentPlayer;
            set { _currentPlayer = value; OnPropertyChanged(); }
        }
        public IGameBoardModel GameGrid { get; set; }
        #endregion

        public GameManagerModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<PlayerTookTurnEvent>().Subscribe(OnPlayerTookTurnEvent);
            InitGameData();
            GameGrid = new GameBoardModel();
        }

        private void InitGameData()
        {
            GameOver = false;
            Player1 = new PlayerModel('X', "Blue");
            Player2 = new PlayerModel('O', "Red");
            CurrentPlayer = Player1;
        }

        public void ResetGameData()
        {
            GameOver = false;
            GameGrid.ResetGrid();
            // changing the color is more efficient than creating two objects
            Player1.PlayerColor = "Blue";
            Player2.PlayerColor = "Red";
            CurrentPlayer = Player1;
        }

        private void OnPlayerTookTurnEvent()
        {
            if (GameGrid.CheckWin())
            {
                GameOver = true;
                CurrentPlayer.PlayerScore++;
                return;
            }

            if(GameGrid.CheckDraw())
            {
                CurrentPlayer.PlayerColor = "LightGray";
                GameOver = true;
                return;
            }

            SwitchCurrentPlayer();
        }

        private void SwitchCurrentPlayer()
        {
            if (CurrentPlayer == Player1)
                CurrentPlayer = Player2;
            else
                CurrentPlayer = Player1;
        }
    }
}
