using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGeneration
{
    class RecursiveDivision : MazeAlgorithm
    {
        private static readonly int LOW_X = 0, LOW_Y = 1, UPP_X = 2, UPP_Y = 3;
        Stack<int[]> splits;
        int[] currSect;

        protected override void Setup()
        {
            splits = new Stack<int[]>();
            currSect = new int[] { 0, 0, grid.GetLength(0), grid.GetLength(1) };
            // Set all cells as created
            foreach (Cell c in grid)
                c.SetCreated();
            SetSectionVal("*");
        }

        public override bool NextCell()
        {
            SetSectionVal("");

            // Sections: Lower bounds are inclusive, Upper bounds are exclusive ?
            // Upper bounds define opposite side of where split is.

            // If section single row or column
            if (currSect[UPP_X] - 1 == currSect[LOW_X] || currSect[UPP_Y] - 1 == currSect[LOW_Y])
            {
                if (splits.Count == 0)
                    return false;
                currSect = splits.Pop();
                SetSectionVal("*");
                return true;
            }

            // Randomly select where split is
            // Draw wall along split and randomly add opening
            if (GetRandBool())
            {
                splitX();
            }
            else
            {
                splitY();
            }

            SetSectionVal("*");
            return true;
        }

        protected void splitX()
        {
            // Randomly split on X-axis
            int s = rand.Next(currSect[LOW_X], currSect[UPP_X] - 1) + 1;
            // Find random opening in wall
            int o = rand.Next(currSect[LOW_Y], currSect[UPP_Y]);

            // Draw wall
            for (int i = currSect[LOW_Y]; i < currSect[UPP_Y]; i++)
            {
                if (i != o)
                    grid[s - 1, i].SetRightWall(true);
            }

            // Set new section as current section and add other section to stack
            splits.Push(new int[] { s, currSect[LOW_Y], currSect[UPP_X], currSect[UPP_Y] });
            currSect = new int[] { currSect[LOW_X], currSect[LOW_Y], s, currSect[UPP_Y] };
        }

        protected void splitY()
        {
            // Randomly split on Y-axis
            int s = rand.Next(currSect[LOW_Y], currSect[UPP_Y] - 1) + 1;
            // Find random opening in wall
            int o = rand.Next(currSect[LOW_X], currSect[UPP_X]);

            // Draw wall
            for (int i = currSect[LOW_X]; i < currSect[UPP_X]; i++)
            {
                if (i != o)
                    grid[i, s - 1].SetLowerWall(true);
            }

            // Set new section as current section and add other section to stack
            splits.Push(new int[] { currSect[LOW_X], s, currSect[UPP_X], currSect[UPP_Y] });
            currSect = new int[] { currSect[LOW_X], currSect[LOW_Y], currSect[UPP_X], s };
        }

        public void SetSectionVal(String _val)
        {
            for (int _x = currSect[LOW_X]; _x < currSect[UPP_X]; _x++)
            {
                for (int _y = currSect[LOW_Y]; _y < currSect[UPP_Y]; _y++)
                {
                    grid[_x, _y].SetValue(_val);
                }
            }
        }

        public override String GetName()
        {
            return "Recursive Division";
        }
    }
}
