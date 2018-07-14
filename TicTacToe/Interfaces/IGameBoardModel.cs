﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public interface IGameBoardModel
    {
        IDictionary<int[], char> GameBoard { get; set; }
    }
}
