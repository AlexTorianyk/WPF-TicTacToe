using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TicTacToe.Utilities;
using TicTacToe.Utilities.Events;

namespace TicTacToe.Model
{
    public class GameManagerModel : PropertyChange, IGameManagerModel
    {
        #region Variables and Fields
        private readonly IEventAggregator _eventAggregator;

        private bool _gameOver = false;
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
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<PlayerTookTurnEvent>().Subscribe(OnPlayerTookTurnEvent);
            InitPlayers();
            GameGrid = new GameBoardModel();
        }

        private void InitPlayers()
        {
            Player1 = new PlayerModel('X', "Blue");
            Player2 = new PlayerModel('O', "Red");
            CurrentPlayer = Player1;
        }

        private void OnPlayerTookTurnEvent()
        {
            if (GameGrid.CheckWin())
            {
                GameOver = true;
                MessageBox.Show($"Player {CurrentPlayer.PlayerSymbol} has won! CYKA");
                CurrentPlayer.PlayerScore++;
                return;
            }
            else if(GameGrid.CheckDraw())
            {
                CurrentPlayer.PlayerColor = "LightGray";
                GameOver = true;
                MessageBox.Show("DRAW Kurwa");
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
