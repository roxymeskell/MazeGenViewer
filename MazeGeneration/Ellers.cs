using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGeneration
{
    class Ellers : MazeAlgorithm
    {
        int currX;
        int currY;
        bool lowerWalls;
        List<int> sets;

        protected override void Setup()
        {
            // Set up set list
            sets = new List<int>();
            // Set all cells as created
            foreach (Cell c in grid)
                c.SetCreated();
            // Setup first row with set numbers
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                grid[i, 0].SetValue(i.ToString());
                sets.Add(i);
            }
            // Set current row and column
            currX = 0;
            currY = 0;
            // Set if doing lower walls
            lowerWalls = false;

            //throw new NotImplementedException();
        }

        public override bool NextCell() {
            // If next right, return true
            if (NextRight())
                return true;

            // If next lower bound, return true
            if (NextLower())
                return true;

            // If next row, return true
            if (NextRow())
                return true;

            // Return false
            return false;
        }

        public bool NextRight()
        {
            // Check if valid row or lower walls
            if (currY < 0 || currY >= grid.GetLength(1) || lowerWalls)
                return false;

            // Check if valid column
            if (currX < 0 || currX >= grid.GetLength(0) - 1)
            {
                currX = 0;
                lowerWalls = true;
                return false;
            }

            // Check if last row
            if (currY == grid.GetLength(1) - 1)
            {
                // Add right wall ONLY if right cell is in same set
                grid[currX, currY].SetRightWall(grid[currX, currY].Value.Equals(grid[currX + 1, currY].Value));
            }
            else
            {
                // Randomly place right wall if right cell not in same set
                // If right cell in same set, place right wall
                grid[currX, currY].SetRightWall(GetRandBool() ||
                    grid[currX, currY].Value.Equals(grid[currX + 1, currY].Value));
            }

            // If no right wall, add right cell to set, remove previous right set from set list
            if (!grid[currX, currY].HasRightWall)
            {
                String oldSet = grid[currX + 1, currY].Value;
                sets.Remove(Int32.Parse(oldSet));
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    if (grid[i, currY].Value.Equals(oldSet))
                        grid[i, currY].SetValue(grid[currX, currY].Value);
                }
            }

            // Advance column
            currX++;
            return true;
        }

        public bool NextLower()
        {
            // Check if valid row
            if (currY < 0 || currY >= grid.GetLength(1))
                return false;

            // Check if valid column
            if (currX < 0 || currX >= grid.GetLength(0))
            {
                for (int i = 0; i < grid.GetLength(0); i++)
                    grid[i, currY].SetVeiwed(false);
                currX = 0;
                currY++;
                lowerWalls = false;
                
                return false;
            }

            // Set cell as viewed
            grid[currX, currY].SetVeiwed(true);

            // Count:
            //  Unviewed cells in set
            //  Cells in set without lower bound
            int unviewed = 0, noLow = 0;
            for (int i = 0; i < grid.GetLength(0); i++) {
                if (grid[i,currY].Value.Equals(grid[currX, currY].Value)) {
                    if (!grid[i,currY].Viewed)
                        unviewed++;
                    else
                        if (!grid[i, currY].HasLowerWall)
                            noLow++;
                }
            }

            // If only cell in set without lower wall, no lower wall
            // Otherwise, randomly place lower wall
            grid[currX, currY].SetLowerWall(!((noLow == 1 && unviewed == 0) || GetRandBool()));

            // Advance column
            currX++;

            return true;
        }

        public bool NextRow()
        {
            // Check if valid row
            if (currY < 1 || currY >= grid.GetLength(1))
                return false;

            // Copy set values down, create new sets as needed, and clear previous row sets
            int nextSet = sets.Max() + 1;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                if (!grid[i, currY - 1].HasLowerWall)
                {
                    grid[i, currY].SetValue(grid[i, currY - 1].Value);
                }
                else
                {
                    grid[i, currY].SetValue(nextSet.ToString());
                    sets.Add(nextSet);
                    nextSet++;
                }
                grid[i, currY - 1].SetValue("");
            }

            return true;
        }

        public override String GetName()
        {
            return "Eller's Algorithm";
        }
    }
}
