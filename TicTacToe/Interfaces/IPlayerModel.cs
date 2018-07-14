using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    interface IPlayerModel
    {
        string PlayerColor { get; set; }
        char PlayerSymbol { get; set; }
        int PlayerScore { get; set; }
    }
}
