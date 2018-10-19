using System.Collections.ObjectModel;
using TicTacToe.Model.Interfaces;

namespace TicTacToe.Model
{
    public class WinAndDrawCheck : IWinAndDrawCheck
    {
        private readonly ObservableCollection<char> _gameGrid;

        public WinAndDrawCheck(ObservableCollection<char> gameGrid)
        {
            _gameGrid = gameGrid;
        }

        public bool CheckWin()
        {
            return CheckHorizontalWin() || CheckVerticalWin() || CheckDiagonalWin();
        }

        #region Check horizontal vertical and diagonal win methods
        private bool CheckHorizontalWin()
        {
            if (_gameGrid[1] != ' ' && ((_gameGrid[1] == _gameGrid[2]) && (_gameGrid[2] == _gameGrid[3])))
                return true;
            else if (_gameGrid[4] != ' ' && ((_gameGrid[4] == _gameGrid[5]) && (_gameGrid[5] == _gameGrid[6])))
                return true;
            else if (_gameGrid[7] != ' ' && ((_gameGrid[7] == _gameGrid[8]) && (_gameGrid[8] == _gameGrid[9])))
                return true;
            else
                return false;
        }

        private bool CheckVerticalWin()
        {
            if (_gameGrid[1] != ' ' && ((_gameGrid[1] == _gameGrid[4]) && (_gameGrid[4] == _gameGrid[7])))
                return true;
            else if (_gameGrid[2] != ' ' && ((_gameGrid[2] == _gameGrid[5]) && (_gameGrid[5] == _gameGrid[8])))
                return true;
            else if (_gameGrid[3] != ' ' && ((_gameGrid[3] == _gameGrid[6]) && (_gameGrid[6] == _gameGrid[9])))
                return true;
            else
                return false;
        }

        private bool CheckDiagonalWin()
        {
            if (_gameGrid[1] != ' ' && ((_gameGrid[1] == _gameGrid[5]) && (_gameGrid[5] == _gameGrid[9])))
                return true;
            else if (_gameGrid[3] != ' ' && ((_gameGrid[3] == _gameGrid[5]) && (_gameGrid[5] == _gameGrid[7])))
                return true;
            else
                return false;
        }
        #endregion

        public bool CheckDraw()
        {
            foreach (var tile in _gameGrid)
            {
                if (tile == ' ')
                    return false;
            }
            return true;
        }
    }
}
