using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeSimulation
{
    public partial class Form1 : Form
    {
        private ColorTheme defaultColorTheme = new ColorTheme(Color.Cyan, Color.FromArgb(34, 34, 34));
        private ColorTheme currentColorTheme;

        private List<GameThread> threads = new List<GameThread>();
        private int threadsCount;

        private Game cgol;
        private const int ROWS = 100;
        private const int COLUMNS = 100;
        private const int CELL_WIDTH = 6;
        public int generation;
        private bool pauseStatus = false;
        private List<bool[,]> grids = new List<bool[,]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentColorTheme = defaultColorTheme;
            gameWindow.BackColor = currentColorTheme.GetBackGround();

            cgol = new Game(new SolidBrush(currentColorTheme.GetForeGround()), ROWS, COLUMNS, CELL_WIDTH);
            generation = 0;

            generationTimer.Start();

            threadsCount = 1;
            CreateGameThreads();
            StartThreads();
        }

        private void gameWindow_Paint(object sender, PaintEventArgs e)
        {
            cgol.Paint(e.Graphics);
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void playPauseBtn_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            StopThreads();
            Application.Exit();
        }

        private void speedTrackBar_Scroll(object sender, EventArgs e)
        {
            PlayPause();
            generationTimer.Interval = 1000 / (speedTrackBar.Value * 8);
            PlayPause();
        }

        private void generationTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
            if (grids.Count >= 8 && cgol.Equals(grids[grids.Count - 8]) || grids.Count >= 4 && cgol.Equals(grids[grids.Count - 4]))
            {
                PlayPause();
                MessageBox.Show("The game can go on no longer. Restarting...", "Game over!", MessageBoxButtons.OK);
                Restart();
            }
        }

        private void threadCount1x(object sender, EventArgs e)
        {
            threadsCount = 1;
            CreateGameThreads();
        }

        private void threadCount2x(object sender, EventArgs e)
        {
            threadsCount = 2;
            CreateGameThreads();
        }

        delegate void CreateGenerationCallback();

        private void CreateGeneration()
        {
            grids.Add((bool[,])cgol.GetGrid().Clone());
            generation++;
            cgol.NewGeneration();
            SetGenerationText(generation);
        }

        delegate void SetGenerationTextCallback(int cound);

        private void SetGenerationText(int count)
        {
            if (generationCount.InvokeRequired)
            {
                SetGenerationTextCallback d = new SetGenerationTextCallback(SetGenerationText);
                Invoke(d, new object[] { count });
            } else
            {
                generationCount.Text = "Generation: " + count.ToString();
            }
        }

        private void Restart()
        {
            cgol = new Game(new SolidBrush(currentColorTheme.GetForeGround()), ROWS, COLUMNS, CELL_WIDTH);
            grids = new List<bool[,]>();
            generation = 0;
            playPauseBtn.Text = "Pause";
            pauseStatus = false;

            generationTimer.Start();
            CreateGameThreads();
            StartThreads();

            Refresh();
        }

        private void PlayPause()
        {
            pauseStatus = !pauseStatus;

            if (pauseStatus)
            {
                generationTimer.Stop();
                StopThreads();
                playPauseBtn.Text = "Play";
            }
            else
            {
                generationTimer.Start();
                CreateGameThreads();
                StartThreads();
                playPauseBtn.Text = "Pause";
            }
        }

        private void StartThreads()
        {
            threads.ForEach(thread =>
            {
                thread.StartThread();
            });
        }

        private void StopThreads()
        {
            threads.ForEach(thread =>
            {
                thread.StopThread();
            });
        }

        private void CreateGameThreads()
        {
            StopThreads();
            threads.Clear();

            for (int i = 0; i < threadsCount; i++)
            {
                threads.Add(new GameThread(CreateGeneration));
            }
        }
    }
}
