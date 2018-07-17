using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Model;
using TicTacToe.Utilities;

namespace TicTacToe.ViewModel
{
    public class MainWindowViewModel
    {
        private readonly IEventAggregator _eventAggregator;
        public IGameManagerModel GameManager { get; set; }
        public RelayCommand PlaceSymbol { get; set; }

        public MainWindowViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            GameManager = new GameManagerModel(_eventAggregator);
            PlaceSymbol = new RelayCommand(OnPlaceSymbol, x => true);
        }

        private void OnPlaceSymbol(object param)
        {
            int placement = Convert.ToInt32(param);
            GameManager.GameGrid.TakeTurn(placement, 'O');
        }
    }
}
