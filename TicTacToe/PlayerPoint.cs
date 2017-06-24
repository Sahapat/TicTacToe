using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
     struct PlayerStatus
    {
        public short health;
        public bool round;
    }
    interface ITicTacToeTable
    {
        void Display();
        bool CheckScore();
    }
}
