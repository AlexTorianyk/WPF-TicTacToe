using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Model;

namespace TicTacToe.ViewModel
{
    public class MainWindowViewModel
    {
        public GameManagerModel gameManagerModel { get; set; }

        public MainWindowViewModel()
        {
            gameManagerModel = new GameManagerModel();
        }
    }
}
