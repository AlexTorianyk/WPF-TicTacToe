using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Utilities.Events;

namespace TicTacToe.Model
{
    public class GameManagerModel : IGameManagerModel
    {
        #region Variables and Fields
        private readonly IEventAggregator _eventAggregator;

        public IPlayerModel Player1 { get; set; }
        public IPlayerModel Player2 { get; set; }
        public IPlayerModel CurrentPlayer { get; set; }
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
            if (CurrentPlayer == Player1)
                CurrentPlayer = Player2;
            else
                CurrentPlayer = Player1;
        }
    }
}
