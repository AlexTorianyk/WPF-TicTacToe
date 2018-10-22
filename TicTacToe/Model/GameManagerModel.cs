using Prism.Events;
using TicTacToe.Model.Interfaces;
using TicTacToe.Utilities;
using TicTacToe.Utilities.Events;

namespace TicTacToe.Model
{
    public class GameManagerModel : PropertyChange, IGameManagerModel
    {
        public IGameBoardModel GameBoard { get; set; }
        public IWinAndDrawCheck WinAndDrawChecker { get; set; }

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

        public GameManagerModel(IEventAggregator eventAggregator)
        {
            InitGameData();
            eventAggregator.GetEvent<PlayerTookTurnEvent>().Subscribe(OnPlayerTookTurnEvent);
            GameBoard = new GameBoardModel();
        }


        private void InitGameData()
        {
            GameOver = false;
            InitPlayers();
        }

        private void InitPlayers()
        {
            Player1 = new PlayerModel('X', "Blue");
            Player2 = new PlayerModel('O', "Red");
            CurrentPlayer = Player1;
        }

        private void OnPlayerTookTurnEvent()
        {
            if (GameBoard.CheckWin())
            {
                CurrentPlayer.PlayerScore++;
                GameOver = true;
                return;
            }

            if(GameBoard.CheckDraw())
            {
                CurrentPlayer.PlayerColor = "LightGray";
                GameOver = true;
                return;
            }

            SwitchCurrentPlayer();
        }

        public void ResetGameData()
        {
            GameOver = false;
            GameBoard.ResetGrid();
            ResetPlayerData();
        }

        private void ResetPlayerData()
        {
            // changing the color is more efficient than creating two objects
            Player1.PlayerColor = "Blue";
            Player2.PlayerColor = "Red";
            CurrentPlayer = Player1;
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
