using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EightQueenPuzzle
{
    public partial class Game : Form
    {
        private ChessBoard cb = new ChessBoard();
        private int i;
        private Stopwatch watch = new Stopwatch();
        public Game()
        {
            InitializeComponent();

        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.Show();
            MessageBox.Show("Place " + cb.N + " queens on the board so that no queen attacks the other..", " Welcome to " + cb.N + " Queen Puzzle!! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cb.Dock = DockStyle.Fill;
            ChessBoardPanel.Controls.Add(cb);
            watch.Start();
            cb.GetSolutions();
            watch.Stop();
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {

            lblShowTime.Text = " Puzzle solved in " + watch.ElapsedMilliseconds + " ms ";

            if (i < cb.Solutions.Count)
            {
                cb.Cells = cb.Solutions[i];
                cb.DrawBoard();
                i += 1;
                lblShowCount.Text = " Showing " + i.ToString() + " of " + cb.Solutions.Count.ToString() + " possible solutions ";
            }
            else
            {
                i = 0;
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            cb.ClearBoard();
            lblShowCount.Text = "";
            lblShowTime.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
