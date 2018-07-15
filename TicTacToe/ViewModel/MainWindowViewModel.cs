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
        public IGameManagerModel GameManager { get; set; }
        public RelayCommand PlaceSymbol { get; set; }

        public MainWindowViewModel()
        {
            GameManager = new GameManagerModel();
            PlaceSymbol = new RelayCommand(OnPlaceSymbol, x => true);
        }

        private void OnPlaceSymbol(object param)
        {
            int placement = Convert.ToInt32(param);
            GameManager.GameGrid.TakeTurn(placement, 'O');
        }
    }
}
