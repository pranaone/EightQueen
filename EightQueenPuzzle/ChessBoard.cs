using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace EightQueenPuzzle
{
    public partial class ChessBoard : UserControl
    {
        private Graphics graphics;
        private Bitmap bitmap;
        private static int n = 8;

        private bool[,] cells = new bool[n,n];
        private List<Queen> queens = new List<Queen>();
        private List<bool[,]> solutions = new List<bool[,]>();
        private bool isUserPlaying = false;
        private bool playing = false;

        

        [Browsable(false)]
        public bool[,] Cells
        {
            get
            {
                return cells;
            }
            set
            {
                cells = value;
            }
        }

        public List<bool[,]> Solutions
        {
            get
            {
                return solutions;
            }
            set
            {
                solutions = value;
            }
        }

        public bool UserPlaying
        {
            get
            {
                return isUserPlaying;
            }
            set
            {
                isUserPlaying = value;
            }
        }

        public int N
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }

        }
        public ChessBoard()
        {
            InitializeComponent();
            DrawBoard();
        }

        private void ChessBoard_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (!playing)
                    {
                        queens.Clear();
                        ResetCells();
                        playing = true;
                        DrawBoard();
                    }
                    isUserPlaying = true;
                    byte colIndex = Convert.ToByte((e.Location.X - this.Left) / 80);
                    byte rowIndex = Convert.ToByte((e.Location.Y - this.Top) / 80);
                    var queenObj = new Queen(rowIndex, colIndex);
                    int index = Exists(ref queenObj);
                    if (queens.Count < n)
                    {
                        if (index > -1)
                        {
                            cells[rowIndex, colIndex] = false;
                            queens.RemoveAt(index);
                        }
                        else
                        {
                            cells[rowIndex, colIndex] = true;
                            queens.Add(new Queen(rowIndex, colIndex));
                        }
                    }
                    else
                    {
                        if (index > -1)
                        {
                            cells[rowIndex, colIndex] = false;
                            queens.RemoveAt(index);
                        }
                    }
                    DrawBoard();
                }

            }
            catch(Exception) {

               // MessageBox.Show("Please disregard and continue!!","Error Occured",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private int Exists(ref Queen Queen)
        {
            if (queens.Count == 0)
            {
                return -1;
            }
            for (byte i = 0; i < queens.Count; i++)
            {
                if (queens[i].Row == Queen.Row && queens[i].Column == Queen.Column)
                {
                    return i;
                }
            }
            return -1;
        }

        private void ChessBoard_Paint(object sender, PaintEventArgs e)
        {
            if (bitmap != null)
            {
                this.BackgroundImage = bitmap;
            }
        }

        private void ChessBoard_Resize(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                DrawBoard();
            }
        }

        public void DrawBoard()
        {
            
            if (this.Width > 0 && this.Height > 0)
            {
                bitmap = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppPArgb);
                graphics = Graphics.FromImage(bitmap);
                LinearGradientBrush br = null;
                RectangleF rectObj = new RectangleF();
                bool flip = true;
                for (float i = 0; i <= n-1; i++) 
                {
                    for (float j = 0; j <= n-1; j++)
                    {
                        var nFloat = (float)(n);
                        rectObj = new RectangleF((float)(j * System.Convert.ToSingle(bitmap.Width / nFloat)), (float)(i * System.Convert.ToSingle(bitmap.Height / nFloat)), System.Convert.ToSingle(bitmap.Width / nFloat), System.Convert.ToSingle(bitmap.Height / nFloat)); 
                        if (flip)
                        {
                            
                            br = new LinearGradientBrush(rectObj, Color.White, Color.Transparent, LinearGradientMode.ForwardDiagonal);
                        }
                        else
                        {
                            br = new LinearGradientBrush(rectObj, Color.Black, Color.Transparent, LinearGradientMode.ForwardDiagonal);
                        }
                        graphics.FillRectangle(br, rectObj);
                        flip = ((j == n-1) ? flip : !flip);

                        var intI = Convert.ToInt32(i);
                        var intJ = Convert.ToInt32(j);


                        if (cells[intI, intJ])
                        {
                            if (isUserPlaying)
                            {
                                var byteI = Convert.ToByte(intI);
                                var byteJ = Convert.ToByte(intJ);
                                var obj = new Queen(byteI, byteJ);

                                int index = Exists(ref obj);
                                if (index > 0)
                                {
                                    if (queens[index] != null)
                                    {
                                        if (!(CheckAll(index)))
                                        {
                                            
                                            graphics.FillEllipse(new LinearGradientBrush(rectObj, Color.Red, Color.Yellow, LinearGradientMode.ForwardDiagonal), rectObj);
                                        }
                                        else
                                        {
                                            graphics.FillEllipse(new LinearGradientBrush(rectObj, Color.Transparent, Color.Transparent, LinearGradientMode.ForwardDiagonal), rectObj);
                                        }
                                    }
                                }
                                else
                                {
                                    graphics.FillEllipse(new LinearGradientBrush(rectObj, Color.Transparent, Color.Transparent, LinearGradientMode.ForwardDiagonal), rectObj);
                                }
                            }
                            else
                            {
                                graphics.FillEllipse(new LinearGradientBrush(rectObj, Color.Green, Color.Yellow, LinearGradientMode.ForwardDiagonal), rectObj);
                            }
                            Image Queen = Image.FromFile("Queen.png");
                            graphics.DrawImage(Queen,rectObj);                        
                        }
                    }
                }
                this.Invalidate();
            }
        }

        public void ResetCells()
        {
            for (byte i = 0; i <= n-1; i++) 
            {
                for (byte j = 0; j <= n-1; j++) 
                {
                    cells[i, j] = false;
                }
            }
        }

        public void FindSolution()
        {
            ResetCells();
            for (byte i = 0; i <= n-1; i++) 
            {
                byte j = 0;
                if (i >= 0 && i < n-1 / 2.0) 
                {
                    j = Convert.ToByte((n / 2.0 + 2 * i - 1) % n);
                }
                else
                {
                    j = Convert.ToByte((n / 2.0 + 2 * i + 2) % n); 
                }
                cells[i, j] = true;
            }
            DrawBoard();
        }

        private bool CheckAll(int Level)
        {
            for (int i = Level; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (queens[i].Row == queens[j].Row || queens[i].Column == queens[j].Column || queens[i].Row + queens[i].Column == queens[j].Row + queens[j].Column | queens[i].Row - queens[j].Row == queens[i].Column - queens[j].Column)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void MoveQueen(int Level)
        {
            if (Level > n-1) 
            {
                for (int j = 0; j <= n-1; j++) 
                {
                    for (int i = 0; i <= n-1; i++) 
                    {
                        if ((queens[j].Row == j) & (queens[j].Column == i))
                        {
                            cells[i, j] = true;
                        }
                        else
                        {
                            cells[i, j] = false;
                        }
                    }
                }
                bool[,] sol = (bool[,])cells.Clone();

                Solutions.Add(sol);
                return;
            }
            for (int j = 0; j <= n-1; j++) 
            {
                if (Level < n) 
                {
                    queens[Level].Row = Level;
                    queens[Level].Column = j;
                    if (CheckAll(Level))
                    {
                        MoveQueen(Level + 1);
                    }
                }
            }
        }

        public void GetSolutions()
        {
            isUserPlaying = false;
            playing = false;
            queens.Clear();
            ResetCells();
            DrawBoard();
            for (int j = 0; j <= n-1; j++)
            {
                queens.Add(new Queen());
            }
            for (int i = 0; i <= n-1; i++) 
            {
                queens[0].Row = 0;
                queens[0].Column = i;
                MoveQueen(1);
            }
        }

        public void ClearBoard()
        {
            isUserPlaying = false;
            playing = false;
            queens.Clear();
            ResetCells();
            DrawBoard();
        }
    }
}
