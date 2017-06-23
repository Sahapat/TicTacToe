using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class XoTable
    {
        private bool[,] _Table = new bool[3, 3];
        public bool[,] Table
        {
            get
            {
                return _Table;
            }
            set
            {
                _Table = value;
            }
        }
        
    }
}
