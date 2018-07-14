using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public interface IGameBoardModel
    {
        ObservableCollection<char> GameGrid { get; set; }
        void TakeTurn(int placement, char symbol);
    }
}
