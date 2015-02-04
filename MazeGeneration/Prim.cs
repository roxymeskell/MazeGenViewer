using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGeneration
{
    /// <summary>
    /// Class to generate a maze using Prim's Algorithm
    /// Extends MazeGeneration
    /// About algorithm --
    /// Requires storage proportional to the size of the Maze
    /// During creation, each cell is one of three types:
    ///     (1) "In": The cell is part of the Maze and has been carved into already
    ///     (2) "Frontier": The cell is not part of the Maze and has not been carved into yet, but is next to a cell that's already "in"
    ///     (3) "Out": The cell is not part of the Maze yet, and none of its neighbors are "in" either.
    ///Start by picking a cell, making it "in", and setting all its neighbors to "frontier".
    ///Proceed by picking a "frontier" cell at random, and carving into it from one of its neighbor cells that are "in".
    ///Change that "frontier" cell to "in", and update any of its neighbors that are "out" to "frontier".
    ///The Maze is done when there are no more "frontier" cells left.
    /// </summary>
    class Prim : MazeAlgorithm
    {
        readonly String IN = "In", OUT = "Out", FRONTEIR = "Fronteir";
        List<Cell> fCells;
        protected override void Setup()
        {
            fCells = new List<Cell>(grid.GetLength(0) * grid.GetLength(1));
            // Set all cells as out
            foreach (Cell _cell in grid)
            {
                _cell.SetValue(OUT);
                _cell.CloseWalls();
            }
            // Pick an initial cell
            SetCurrCell(grid[rand.Next(grid.GetLength(0)), rand.Next(grid.GetLength(1))]);
            // Set initial cell as in
            SetCurrAsIn();
            //throw new NotImplementedException();
        }

        public override bool NextCell()
        {
            // If no fronteir cells, return false
            if (fCells.Count == 0)
                return false;
            
            // Randomly select cell from fronteir cells
            SetCurrCell(fCells.ElementAt(rand.Next(fCells.Count)));
            // Carve opening
            List<Cell> _possIn = new List<Cell>();
            for (int _x = -1; _x < 2; _x++)
                if (_x + currCell.X >= 0 && _x + currCell.X < grid.GetLength(0))
                    if (grid[_x + currCell.X, currCell.Y].Value.Equals(IN))
                        _possIn.Add(grid[_x + currCell.X, currCell.Y]);
            for (int _y = -1; _y < 2; _y++)
                if (_y + currCell.Y >= 0 && _y + currCell.Y < grid.GetLength(1))
                    if (grid[currCell.X, _y + currCell.Y].Value.Equals(IN))
                        _possIn.Add(grid[currCell.X, _y + currCell.Y]);
            Cell _in = _possIn.ElementAt(rand.Next(_possIn.Count));
            if (currCell.X == _in.X)
                if (currCell.Y < _in.Y)
                    currCell.SetLowerWall(false);
                else
                    _in.SetLowerWall(false);
            else
                if (currCell.X < _in.X)
                    currCell.SetRightWall(false);
                else
                    _in.SetRightWall(false);

            SetCurrAsIn();
            return true;

            //throw new NotImplementedException();
        }

        /// <summary>
        /// Sets current cell as "In" and the cells around it, if out, as "Frontier"
        /// </summary>
        protected void SetCurrAsIn()
        {
            currCell.SetCreated();
            currCell.SetValue(IN);
            fCells.Remove(currCell);
            for (int _x = -1; _x < 2; _x++)
                if (_x + currCell.X >= 0 && _x + currCell.X < grid.GetLength(0))
                    if (grid[_x + currCell.X, currCell.Y].Value.Equals(OUT))
                    {
                        grid[_x + currCell.X, currCell.Y].SetValue(FRONTEIR);
                        fCells.Add(grid[_x + currCell.X, currCell.Y]);
                    }
            for (int _y = -1; _y < 2; _y++)
                if (_y + currCell.Y >= 0 && _y + currCell.Y < grid.GetLength(1))
                    if (grid[currCell.X, _y + currCell.Y].Value.Equals(OUT))
                    {
                        grid[currCell.X, _y + currCell.Y].SetValue(FRONTEIR);
                        fCells.Add(grid[currCell.X, _y + currCell.Y]);
                    }
        }
        
        public override String GetName()
        {
            return "Prim's Algorithm";
        }
    }
}
