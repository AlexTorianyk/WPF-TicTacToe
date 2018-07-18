﻿using TicTacToe.Model;

namespace TicTacToe.Interfaces
{
    public interface IGameManagerModel
    {
        bool GameOver { get; set; }
        IPlayerModel Player1 { get; set; }
        IPlayerModel Player2 { get; set; }
        IPlayerModel CurrentPlayer { get; set; }
        void ResetGameData();
        IGameBoardModel GameGrid { get; set; }
    }
}