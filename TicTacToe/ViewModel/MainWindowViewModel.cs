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
        public IGameManagerModel GameManager { get; set; }

        public MainWindowViewModel()
        {
            GameManager = new GameManagerModel();
        }
    }
}
