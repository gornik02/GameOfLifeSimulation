using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameOfLifeSimulation
{
    class Game
    {
        private int threadCount;
        private List<CancellableTask> threads;

        private GameCalculations gameCalculations;
        private const int ROWS = 100;
        private const int COLUMNS = 100;
        private const int CELL_WIDTH = 6;
        private int generation;
        private bool isRunning;
        private List<bool[,]> grids;

        private Timer timer;

        private Brush myCellColor;

        public Game(ColorTheme currentColorTheme, Timer timer)
        {
            this.timer = timer;
            isRunning = false;
            myCellColor = new SolidBrush(currentColorTheme.GetForeGround());

            threadCount = 1;
            threads = new List<CancellableTask>();

            gameCalculations = new GameCalculations(ROWS, COLUMNS);
            grids = new List<bool[,]>();
            generation = 0;
        }

        public void Start()
        {
            isRunning = true;
            StopAndClearGameThreads();
            CreateGameThreads();
            StartGameThreads();
        }

        public void Stop()
        {
            isRunning = false;
            StopAndClearGameThreads();
        }

        public bool IsGameRunning()
        {
            return isRunning;
        }

        public void Restart()
        {
            Stop();
            gameCalculations = new GameCalculations(ROWS, COLUMNS);
            grids = new List<bool[,]>();
            generation = 0;
        }

        public int GetGeneration()
        {
            return generation;
        }

        public void Paint(Graphics g)
        {
            bool[,] grid = gameCalculations.GetGrid();

            for (int r = 0; r < grid.GetLength(0); r++)
            {
                for (int c = 0; c < grid.GetLength(1); c++)
                {
                    if (grid[r, c])
                        g.FillRectangle(myCellColor, c * CELL_WIDTH, r * CELL_WIDTH, CELL_WIDTH, CELL_WIDTH);
                }
            }
        }

        private void CreateGeneration(Object source, ElapsedEventArgs e)
        {
            grids.Add((bool[,])gameCalculations.GetGrid().Clone());
            generation++;
            gameCalculations.NewGeneration();
        }

        public void UpdateThreadCount(int updatedThreadCount)
        {
            threadCount = updatedThreadCount;
        }

        private void CreateGameThreads()
        {
            for (int i = 0; i < threadCount; i++)
            {
                AddGameThread();
            }
        }

        private void AddGameThread()
        {
            threads.Add(new CancellableTask(() =>
            {
                timer.Elapsed += CreateGeneration;
            }));
        }

        private void StartGameThreads()
        {
            threads.ForEach(t => t.Start());
        }

        private void StopAndClearGameThreads()
        {
            threads.ForEach(t => t.Cancel());
            threads.Clear();
        }
    }
}
