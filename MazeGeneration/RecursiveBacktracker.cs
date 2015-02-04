using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGeneration
{
    class RecursiveBacktracker : MazeAlgorithm
    {
        Stack<Cell> cellStack;
        //Cell currCell;

        protected override void Setup()
        {
            cellStack = new Stack<Cell>();
            foreach (Cell _cell in grid)
            {
                _cell.CloseWalls();
            }
            SetCurrCell(grid[rand.Next(grid.GetLength(0)), rand.Next(grid.GetLength(1))]);
        }

        public override bool NextCell()
        {
            //If currCell is null, return
            if (currCell == null)
            {
                return false;
            }

            int directionsLookedIn = 0;

            //Create currCell
            currCell.SetCreated();

            //Randomize which direction to look in first
            switch (rand.Next(4))
            {
                case 0:
                    //If exists and is not created, get right neighbor and return method
                    if (currCell.X != grid.GetUpperBound(0))
                    {
                        if (!grid[currCell.X + 1, currCell.Y].Created)
                        {
                            currCell.SetRightWall(false);
                            cellStack.Push(currCell);
                            SetCurrCell(grid[currCell.X + 1, currCell.Y]);
                            return true;
                        }
                    }
                    directionsLookedIn++;
                    if (directionsLookedIn < 4)
                        goto case 1;
                    break;
                case 1:
                    //If exists and is not created, get lower neighbor and return method
                    if (currCell.Y != grid.GetUpperBound(1))
                    {
                        if (!grid[currCell.X, currCell.Y + 1].Created)
                        {
                            currCell.SetLowerWall(false);
                            cellStack.Push(currCell);
                            SetCurrCell(grid[currCell.X, currCell.Y + 1]);
                            return true;
                        }
                    }
                    directionsLookedIn++;
                    if (directionsLookedIn < 4)
                        goto case 2;
                    break;
                case 2:
                    //If exists and is not created, get left neighbor and return method
                    if (currCell.X != 0)
                    {
                        if (!grid[currCell.X - 1, currCell.Y].Created)
                        {
                            cellStack.Push(currCell);
                            SetCurrCell(grid[currCell.X - 1, currCell.Y]);
                            currCell.SetRightWall(false);
                            return true;
                        }
                    }
                    directionsLookedIn++;
                    if (directionsLookedIn < 4)
                        goto case 3;
                    break;
                case 3:
                    //If exists and is not created, get upper neighbor and return method
                    if (currCell.Y != 0)
                    {
                        if (!grid[currCell.X, currCell.Y - 1].Created)
                        {
                            cellStack.Push(currCell);
                            SetCurrCell(grid[currCell.X, currCell.Y - 1]);
                            currCell.SetLowerWall(false);
                            return true;
                        }
                    }
                    directionsLookedIn++;
                    if (directionsLookedIn < 4)
                        goto case 0;
                    break;
            }

            //If no cells exist or are uncreated, get cell from top of stack
            if (cellStack.Count != 0)
            {
                SetCurrCell(cellStack.Pop());
                return true;
            }
            else
            {
                SetCurrCell(null);
                return false;
            }
        }

        public override String GetName()
        {
            return "Recursive Backtracker";
        }
    }
}
