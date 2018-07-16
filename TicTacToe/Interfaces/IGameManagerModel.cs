using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public interface IGameManagerModel
    {
        IPlayerModel Player1 { get; set; }
        IPlayerModel Player2 { get; set; }
        IPlayerModel CurrentPlayer { get; set; }
        IGameBoardModel GameGrid { get; set; }
    }
}