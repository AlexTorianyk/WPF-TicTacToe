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
            // since Player 1 is the only one who is able to be a current player at a draw
            // and the scores colors at the top are bound to that of the player's
            // i thought it'd be more efficient to just change his colour, than create 2 new objects
            // and add a background property and the OnPropertyChanged()[i'm lazey]
            Player1.PlayerColor = "Blue";
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
