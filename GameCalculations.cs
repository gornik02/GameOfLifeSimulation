using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeSimulation
{
    class GameCalculations
    {
        private bool[,] myGrid;
        private int myRows, myColumns;

        public GameCalculations(int rows, int columns, int cellWidth)
        {
            myRows = rows;
            myColumns = columns;

            myGrid = new bool[myRows, myColumns];


            Random randomGenerator = new Random();
            for (int r = 0; r < myGrid.GetLength(0); r++)
            {
                for (int c = 0; c < myGrid.GetLength(1); c++)
                {
                    int randomNumber = randomGenerator.Next(8);
                    if (randomNumber == 0)
                        myGrid[r, c] = true;
                }
            }
        }

        private int CheckStatus(int row, int col)
        {

            int count = 0;

            if ((row - 1 >= 0 && col - 1 > 0) && myGrid[row - 1, col - 1] == true)
                count++;
            if ((row - 1 >= 0) && myGrid[row - 1, col] == true)
                count++;
            if ((row - 1 >= 0 && col + 1 < myColumns) && myGrid[row - 1, col + 1] == true)
                count++;
            if ((col - 1 >= 0) && myGrid[row, col - 1] == true)
                count++;
            if ((col + 1 < myColumns) && myGrid[row, col + 1] == true)
                count++;
            if ((row + 1 < myRows && col - 1 >= 0) && myGrid[row + 1, col - 1] == true)
                count++;
            if ((row + 1 < myRows) && myGrid[row + 1, col] == true)
                count++;
            if ((row + 1 < myRows && col + 1 < myColumns) && myGrid[row + 1, col + 1] == true)
                count++;

            return count;
        }

        public void NewGeneration()
        {
            bool[,] newGrid = new bool[myRows, myColumns];
            for (int r = 0; r < myGrid.GetLength(0); r++)
            {
                for (int c = 0; c < myGrid.GetLength(1); c++)
                {
                    int count = CheckStatus(r, c);


                    if (myGrid[r, c])
                    {
                        if (count == 2 || count == 3)
                            newGrid[r, c] = true;
                        if (count < 2 || count > 3)
                            newGrid[r, c] = false;
                    }
                    else
                    {
                        if (count == 3)
                            newGrid[r, c] = true;
                    }
                }
            }
            myGrid = newGrid;
        }

        public bool[,] GetGrid()
        {
            return myGrid;
        }

        public bool Equals(bool[,] g)
        {
            for (int r = 0; r < myGrid.GetUpperBound(0); r++)
                for (int c = 0; c < myGrid.GetUpperBound(1); c++)
                    if (myGrid[r, c] != g[r, c])
                        return false;
            return true;
        }
    }
}
