using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoPlayerWF
{
    public partial class Form1 : Form
    {
        BingoGame _game;
        public Form1()
        {
            InitializeComponent();
            NewGame();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            if (keyData == Keys.Enter)
            {
                Next();
                return true;
            }
            if (keyData == Keys.F5)
            {
                ToggleTimer();
                return true;
            }
            if (keyData == Keys.F12)
            {
                NewGame();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            _game = new BingoGame();
            currentBall.Text = "";
            previousBall.Text = "";
            grpPrevious.Controls.Clear();
        }


        void Next()
        {
            var next = _game.GetNext();

            if(string.IsNullOrEmpty(next))
                timerStep.Enabled = false;

            if (!string.IsNullOrEmpty(next))
            {
                var ball = new BingoBall();
                ball.Text = next;
                ball.Top = BallMargins;
                ball.Left = BallMargins;
                var w = BallWidth;

                ball.Width = w;
                ball.Height = w;

                if (grpPrevious.Controls.Count > 0)
                {
                    var previous = grpPrevious.Controls[grpPrevious.Controls.Count - 1];
                    ball.Left = previous.Right;
                    ball.Top = previous.Top;
                    if (ball.Left + ball.Width > grpPrevious.Width)
                    {
                        ball.Left = BallMargins;
                        ball.Top = previous.Bottom;
                    }
                }

                grpPrevious.Controls.Add(ball);
            }
            previousBall.Text = currentBall.Text;
            currentBall.Text = next;
        }

        int BallMargins = 30;

        int BallWidth
        {
            get
            {
                int maxWidth = Math.Max(100, (grpPrevious.Width - BallMargins * 2) / 15);
                int maxHeight = Math.Max(100, (grpPrevious.Height - BallMargins * 2) / 5);
                return Math.Min(maxWidth, maxHeight);
            }
        }

        private void grpPrevious_Resize(object sender, EventArgs e)
        {
            var w = BallWidth;
            Control previous = null;
            foreach (Control c in grpPrevious.Controls)
            {
                c.Width = w;
                c.Height = w;
                if (previous == null)
                {
                    c.Left = BallMargins;
                    c.Top = BallMargins;
                }
                else
                {
                    c.Left = previous.Right;
                    c.Top = previous.Top;
                    if (c.Left + c.Width > grpPrevious.Width)
                    {
                        c.Left = BallMargins;
                        c.Top = previous.Bottom;
                    }
                }
                previous = c;
            }
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private int NextTime
        {
            get
            {
                return (int)txtNext.Value;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            ToggleTimer();
        }

        DateTime _timeNext;
        private void ToggleTimer()
        {
            timerStep.Enabled = !timerStep.Enabled;

            if (timerStep.Enabled)
            {
                _timeNext = DateTime.Now;
                btnAuto.Text = "Stop!";
                progressBar1.Maximum = NextTime * 100;
                progressBar1.Value = 0;
                txtNext.Enabled = false;
            }
            else
            {
                btnAuto.Text = "Auto Next";
                progressBar1.Value = 0;
                txtNext.Enabled = true;
            }
        }

        private void timerStep_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var diff = (_timeNext - now).TotalSeconds;

            if (diff < 0.5)
            {
                _timeNext = now.AddSeconds(NextTime);
                Next();
                progressBar1.Value = 0;
            }
            else
            {
                progressBar1.Value = (int)(diff*100);
            }

        }
    }
}
