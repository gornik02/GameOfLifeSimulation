using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GameOfLifeSimulation
{
    public partial class Form1 : Form
    {
        private ColorTheme defaultColorTheme = new ColorTheme(Color.Cyan, Color.FromArgb(34, 34, 34));
        private ColorTheme currentColorTheme;

        private Game game;
        private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 125;
            timer.Elapsed += OnTimerTick;

            currentColorTheme = defaultColorTheme;
            gameWindow.BackColor = currentColorTheme.GetBackGround();
            game = new Game(currentColorTheme, timer);
        }

        private void gameWindow_Paint(object sender, PaintEventArgs e)
        {
            game.Paint(e.Graphics);
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void playPauseBtn_Click(object sender, EventArgs e)
        {
            if (game.IsGameRunning())
            {
                Pause();
            } else
            {
                Play();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void threadCount_Scroll(object sender, EventArgs e)
        {
            Pause();
            game.UpdateThreadCount(threadCountBar.Value);
            Play();
        }

        private void OnTimerTick(Object source, ElapsedEventArgs e)
        {
            SafeAction(Refresh);
            SafeAction(() =>
            {
                generationCount.Text = "Generation: " + game.GetGeneration();
            });

            if (game.ShouldFinish() && game.IsGameRunning())
            {
                Pause();
                MessageBox.Show("The game can go on no longer. Restarting...", "Game over!", MessageBoxButtons.OK);
                Restart();
            }
        }

        private void Restart()
        {
            game.Restart();
            SafeAction(Refresh);
            SafeAction(() =>
            {
                generationCount.Text = "Generation: " + game.GetGeneration();
            });
        }

        private void Play()
        {
            game.Start();
            timer.Start();

            SafeAction(() =>
            {
                playPauseBtn.Text = "Pause";
            });
        }

        private void Pause()
        {
            game.Stop();
            timer.Stop();

            SafeAction(() =>
            {
                playPauseBtn.Text = "Play";
            });
        }

        private void SafeAction(Action action)
        {
            if (InvokeRequired)
            {
                Action safeAction = delegate
                {
                    SafeAction(action);
                };
                Invoke(safeAction);
            }
            else
            {
                action();
            }
        }
    }
}
