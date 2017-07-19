using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private XoTable GameTable = new XoTable();
        private byte round = 1;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Block1_Click(object sender, EventArgs e)
        {
            byte row = 0, column = 0;
            if(CheckEmpty(row,column))
            {
                GameTable.FillBlock(row, column,round);
                round++;
            }
            UpdateTable(1);
            CheckWinner(1);
            CheckWinner(4);
            CheckWinner(7);
        }

        private void Block2_Click(object sender, EventArgs e)
        {
            byte row = 0, column = 1;
            if(CheckEmpty(row,column))
            {
                GameTable.FillBlock(row, column, round);
                round++;
            }
            UpdateTable(2);
            CheckWinner(2);
            CheckWinner(4);
        }

        private void Block3_Click(object sender, EventArgs e)
        {
            byte row = 0, column = 2;
            if (CheckEmpty(row, column))
            {
                GameTable.FillBlock(row, column, round);
                round++;
            }
            UpdateTable(3);
            CheckWinner(3);
            CheckWinner(4);
            CheckWinner(8);
        }

        private void Block4_Click(object sender, EventArgs e)
        {
            byte row = 1, column = 0;
            if (CheckEmpty(row, column))
            {
                GameTable.FillBlock(row, column, round);
                round++;
            }
            UpdateTable(4);
            CheckWinner(1);
            CheckWinner(5);
        }

        private void Block5_Click(object sender, EventArgs e)
        {
            byte row = 1, column = 1;
            if (CheckEmpty(row, column))
            {
                GameTable.FillBlock(row, column, round);
                round++;
            }
            UpdateTable(5);
            CheckWinner(2);
            CheckWinner(5);
            CheckWinner(7);
            CheckWinner(8);
        }

        private void Block6_Click(object sender, EventArgs e)
        {
            byte row = 1, column = 2;
            if (CheckEmpty(row, column))
            {
                GameTable.FillBlock(row, column, round);
                round++;
            }
            UpdateTable(6);
            CheckWinner(3);
            CheckWinner(5);
        }

        private void Block7_Click(object sender, EventArgs e)
        {
            byte row = 2, column = 0;
            if (CheckEmpty(row, column))
            {
                GameTable.FillBlock(row, column, round);
                round++;
            }
            UpdateTable(7);
            CheckWinner(1);
            CheckWinner(6);
            CheckWinner(8);
        }

        private void Block8_Click(object sender, EventArgs e)
        {
            byte row = 2, column = 1;
            if (CheckEmpty(row, column))
            {
                GameTable.FillBlock(row, column, round);
                round++;
            }
            UpdateTable(8);
            CheckWinner(2);
            CheckWinner(6);
        }
        
        private void Block9_Click(object sender, EventArgs e)
        {
            byte row = 2, column = 2;
            if (CheckEmpty(row, column))
            {
                GameTable.FillBlock(row, column, round);
                round++;
            }
            UpdateTable(9);
            CheckWinner(3);
            CheckWinner(6);
            CheckWinner(7);
        }
        private bool CheckEmpty(byte row,byte column)
        {
            if(GameTable.Table[row,column] != GameState.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void UpdateTable(byte block)
        {
            switch(block)
            {
                case 1:
                    if(GameTable.Table[0,0] == GameState.X)
                    {
                        Block1.Text = "X";
                    }
                    else if(GameTable.Table[0, 0] == GameState.O)
                    {
                        Block1.Text = "O";
                    }
                    else
                    {
                        Block1.Text = string.Empty;
                    }
                    break;
                case 2:
                    if (GameTable.Table[0, 1] == GameState.X)
                    {
                        Block2.Text = "X";
                    }
                    else if (GameTable.Table[0, 1] == GameState.O)
                    {
                        Block2.Text = "O";
                    }
                    else
                    {
                        Block2.Text = string.Empty;
                    }
                    break;
                case 3:
                    if (GameTable.Table[0, 2] == GameState.X)
                    {
                        Block3.Text = "X";
                    }
                    else if (GameTable.Table[0, 2] == GameState.O)
                    {
                        Block3.Text = "O";
                    }
                    else
                    {
                        Block3.Text = string.Empty;
                    }
                    break;
                case 4:
                    if (GameTable.Table[1, 0] == GameState.X)
                    {
                        Block4.Text = "X";
                    }
                    else if (GameTable.Table[1, 0] == GameState.O)
                    {
                        Block4.Text = "O";
                    }
                    else
                    {
                        Block4.Text = string.Empty;
                    }
                    break;
                case 5:
                    if (GameTable.Table[1, 1] == GameState.X)
                    {
                        Block5.Text = "X";
                    }
                    else if (GameTable.Table[1, 1] == GameState.O)
                    {
                        Block5.Text = "O";
                    }
                    else
                    {
                        Block5.Text = string.Empty;
                    }
                    break;
                case 6:
                    if (GameTable.Table[1, 2] == GameState.X)
                    {
                        Block6.Text = "X";
                    }
                    else if (GameTable.Table[1, 2] == GameState.O)
                    {
                        Block6.Text = "O";
                    }
                    else
                    {
                        Block6.Text = string.Empty;
                    }
                    break;
                case 7:
                    if (GameTable.Table[2, 0] == GameState.X)
                    {
                        Block7.Text = "X";
                    }
                    else if (GameTable.Table[2, 0] == GameState.O)
                    {
                        Block7.Text = "O";
                    }
                    else
                    {
                        Block7.Text = string.Empty;
                    }
                    break;
                case 8:
                    if (GameTable.Table[2, 1] == GameState.X)
                    {
                        Block8.Text = "X";
                    }
                    else if (GameTable.Table[2, 1] == GameState.O)
                    {
                        Block8.Text = "O";
                    }
                    else
                    {
                        Block8.Text = string.Empty;
                    }
                    break;
                case 9:
                    if (GameTable.Table[2, 2] == GameState.X)
                    {
                        Block9.Text = "X";
                    }
                    else if (GameTable.Table[2, 2] == GameState.O)
                    {
                        Block9.Text = "O";
                    }
                    else
                    {
                        Block9.Text = string.Empty;
                    }
                    break;
            }
        }
        private void CheckWinner(byte pattern)
        {
            switch(pattern)
            {
                case 1:
                    if(GameTable.Table[0,0] == GameState.X && GameTable.Table[1, 0] == GameState.X && GameTable.Table[2, 0] == GameState.X)
                    {
                        EndGame(true);
                    }
                    else if (GameTable.Table[0, 0] == GameState.O && GameTable.Table[1, 0] == GameState.O && GameTable.Table[2, 0] == GameState.O)
                    {
                        EndGame(false);
                    }
                        break;
                case 2:
                    if (GameTable.Table[0, 1] == GameState.X && GameTable.Table[1, 1] == GameState.X && GameTable.Table[2, 1] == GameState.X)
                    {
                        EndGame(true);
                    }
                    else if (GameTable.Table[0, 1] == GameState.O && GameTable.Table[1, 1] == GameState.O && GameTable.Table[2, 1] == GameState.O)
                    {
                        EndGame(false);
                    }
                    break;
                case 3:
                    if (GameTable.Table[0, 2] == GameState.X && GameTable.Table[1, 2] == GameState.X && GameTable.Table[2, 2] == GameState.X)
                    {
                        EndGame(true);
                    }
                    else if (GameTable.Table[0, 2] == GameState.O && GameTable.Table[1, 2] == GameState.O && GameTable.Table[2, 2] == GameState.O)
                    {
                        EndGame(false);
                    }
                    break;
                case 4:
                    if (GameTable.Table[0, 0] == GameState.X && GameTable.Table[0, 1] == GameState.X && GameTable.Table[0, 2] == GameState.X)
                    {
                        EndGame(true);
                    }
                    else if (GameTable.Table[0, 0] == GameState.O && GameTable.Table[0, 1] == GameState.O && GameTable.Table[0, 2] == GameState.O)
                    {
                        EndGame(false);
                    }
                    break;
                case 5:
                    if (GameTable.Table[1, 0] == GameState.X && GameTable.Table[1, 1] == GameState.X && GameTable.Table[1, 2] == GameState.X)
                    {
                        EndGame(true);
                    }
                    else if (GameTable.Table[1, 0] == GameState.O && GameTable.Table[1, 1] == GameState.O && GameTable.Table[1, 2] == GameState.O)
                    {
                        EndGame(false);
                    }
                    break;
                case 6:
                    if (GameTable.Table[2, 0] == GameState.X && GameTable.Table[2, 1] == GameState.X && GameTable.Table[2, 2] == GameState.X)
                    {
                        EndGame(true);
                    }
                    else if (GameTable.Table[2, 0] == GameState.O && GameTable.Table[2, 1] == GameState.O && GameTable.Table[2, 2] == GameState.O)
                    {
                        EndGame(false);
                    }
                    break;
                case 7:
                    if (GameTable.Table[0, 0] == GameState.X && GameTable.Table[1, 1] == GameState.X && GameTable.Table[2, 2] == GameState.X)
                    {
                        EndGame(true);
                    }
                    else if (GameTable.Table[0, 0] == GameState.O && GameTable.Table[1, 1] == GameState.O && GameTable.Table[2, 2] == GameState.O)
                    {
                        EndGame(false);
                    }
                    break;
                case 8:
                    if (GameTable.Table[2, 0] == GameState.X && GameTable.Table[1, 1] == GameState.X && GameTable.Table[0, 2] == GameState.X)
                    {
                        EndGame(true);
                    }
                    else if (GameTable.Table[2, 0] == GameState.O && GameTable.Table[1, 1] == GameState.O && GameTable.Table[0, 2] == GameState.O)
                    {
                        EndGame(false);
                    }
                    break;
            }
        }
        private void EndGame(bool winner)
        {
            if(winner)
            {
                MessageBox.Show("X Winner");
            }
            else
            {
                MessageBox.Show("O Winner");
            }
            GameTable.ClearTable();
            round = 1;
            Block1.Text = string.Empty;
            Block2.Text = string.Empty;
            Block3.Text = string.Empty;
            Block4.Text = string.Empty;
            Block5.Text = string.Empty;
            Block6.Text = string.Empty;
            Block7.Text = string.Empty;
            Block8.Text = string.Empty;
            Block9.Text = string.Empty;
        }
    }
}
