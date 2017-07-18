using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
   public enum GameState
    {
        Empty,
        X,
        O
    };
    class XoTable
    {
        private GameState[,] _Table = new GameState[3, 3];
        public GameState[,] Table
        {
            get
            {
                return _Table;
            }
            private set
            {
                _Table = value;
            }
        }
        public XoTable()
        {
            ClearTable();
        }
        public void FillBlock(byte row, byte column,byte round)
        {
            try
            {
                if(round % 2 == 0)
                {
                    Table[row, column] = GameState.O;
                }
                else
                {
                    Table[row, column] = GameState.X;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ClearTable()
        {
            for(int i = 0;i<3;i++)
            {
                for(int j = 0;j<3;j++)
                {
                    Table[i, j] = GameState.Empty;
                }
            }
        }
    }
}
