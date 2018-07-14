using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public interface IGameManagerModel
    {
        PlayerModel Player1 { get; set; }
        PlayerModel Player2 { get; set; }
    }
}
