using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeSimulation
{
    public partial class Form1 : Form
    {
        private ColorTheme defaultColorTheme = new ColorTheme(Color.Cyan, Color.FromArgb(34, 34, 34));
        private ColorTheme currentColorTheme;

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
            grids.Add((bool[,])cgol.GetGrid().Clone());
            if (grids.Count >= 7 && cgol.Equals(grids[grids.Count - 7]) || grids.Count >= 3 && cgol.Equals(grids[grids.Count - 3]))
            {
                PlayPause();
                MessageBox.Show("The game can go on no longer. Restarting...", "Game over!", MessageBoxButtons.OK);
                Restart();
            }
            else
            {
                generation++;
                cgol.NewGeneration();
                generationCount.Text = "Generation: " + generation.ToString();
                Refresh();
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
            Refresh();
        }

        private void PlayPause()
        {
            pauseStatus = !pauseStatus;

            if (pauseStatus)
            {
                generationTimer.Stop();
                playPauseBtn.Text = "Play";
            }
            else
            {
                generationTimer.Start();
                playPauseBtn.Text = "Pause";
            }
        }
    }
}
