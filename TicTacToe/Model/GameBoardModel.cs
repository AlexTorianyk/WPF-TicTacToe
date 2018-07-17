﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Utilities;

namespace TicTacToe.Model
{
    public class GameBoardModel : PropertyChange, IGameBoardModel
    {
        // i used an abservable collection because it's much less trouble to represent something in the UI with it
        private ObservableCollection<char> _gameGrid;
        public ObservableCollection<char> GameGrid
        {
            get => _gameGrid;
            set { _gameGrid = value; OnPropertyChanged(); }
        }

        public GameBoardModel()
        {
            ResetGrid();
        }

        private void ResetGrid()
        {
            GameGrid = new ObservableCollection<char> {'E', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
        }

        // Simulates a player placing a symbol on the grid
        public void TakeTurn(int placement, char symbol)
        {
            if (GameGrid[placement] == ' ')
            {
                GameGrid[placement] = symbol;
            }
        }

        public bool CheckWin()
        {
            bool ViVon = false;
            return ViVon;
        }

        #region CheckWin Helpers
        private bool CheckHorizontalWin()
        {
            if (GameGrid[1] != ' ' && ((GameGrid[1] == GameGrid[2]) && (GameGrid[2] == GameGrid[3])))
                return true;
            else if (GameGrid[4] != ' ' && ((GameGrid[4] == GameGrid[5]) && (GameGrid[5] == GameGrid[6])))
                return true;
            else if (GameGrid[7] != ' ' && ((GameGrid[7] == GameGrid[8]) && (GameGrid[8] == GameGrid[9])))
                return true;
            else
                return false;
        }

        private bool CheckVerticalWin()
        {
            if (GameGrid[1] != ' ' && ((GameGrid[1] == GameGrid[4]) && (GameGrid[4] == GameGrid[7])))
                return true;
            else if (GameGrid[2] != ' ' && ((GameGrid[2] == GameGrid[5]) && (GameGrid[5] == GameGrid[8])))
                return true;
            else if (GameGrid[3] != ' ' && ((GameGrid[3] == GameGrid[6]) && (GameGrid[6] == GameGrid[9])))
                return true;
            else
                return false;
        }

        private bool CheckDiagonalWin()
        {
            if (GameGrid[1] != ' ' && ((GameGrid[1] == GameGrid[5]) && (GameGrid[5] == GameGrid[9])))
                return true;
            else if (GameGrid[3] != ' ' && ((GameGrid[3] == GameGrid[5]) && (GameGrid[5] == GameGrid[7])))
                return true;
            else
                return false;
        }
        #endregion

        //if atleast on of the tiles is blank, no draw
        public bool CheckDraw()
        {
            foreach (char tile in GameGrid)
            {
                if (tile == ' ')
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
