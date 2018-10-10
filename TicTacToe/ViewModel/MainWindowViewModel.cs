using Prism.Events;
using System;
using TicTacToe.Interfaces;
using TicTacToe.Model;
using TicTacToe.Utilities;
using TicTacToe.Utilities.Events;

namespace TicTacToe.ViewModel
{
    public class MainWindowViewModel
    {
        private readonly IEventAggregator _eventAggregator;
        public IGameManagerModel GameManager { get; set; }
        public RelayCommand PlaceSymbol { get; set; }
        public RelayCommand NewGame { get; set; }

        public MainWindowViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator ?? throw new ArgumentNullException(nameof(eventAggregator));
            GameManager = new GameManagerModel(_eventAggregator);
            PlaceSymbol = new RelayCommand(OnPlaceSymbol, x => true);
            NewGame = new RelayCommand(OnNewGame, x => true);
        }

        private void OnPlaceSymbol(object param)
        {
            var placement = Convert.ToInt32(param);
            // placement is a tag in the UI that represents the grid cell that the user clicked on
            GameManager.GameGrid.TakeTurn(placement, GameManager.CurrentPlayer.PlayerSymbol);
            // publishes an event to the GameManagerModel to determine if the game has ended 
            // if not, change the current player
            _eventAggregator.GetEvent<PlayerTookTurnEvent>().Publish();
        }

        private void OnNewGame(object param)
        {
            GameManager.ResetGameData();
        }
    }
}
