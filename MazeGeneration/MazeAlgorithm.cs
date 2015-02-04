using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGeneration
{
    /// <summary>
    /// An abstract class for maze generation objects.
    /// </summary>
    abstract class MazeAlgorithm
    {

        protected static readonly Random rand = new Random();

        protected Cell[,] grid;
        protected Cell currCell;

        /// <summary>
        /// A static method to recieve the grid for the maze and setup the generation algorithm.
        /// </summary>
        /// <param name="mazeGrid">The grid of cells that represents the maze.</param>
        public void Setup(Cell[,] _grid)
        {
            grid = _grid;
            try
            {
                Setup();
            }
            catch (Exception e)
            {
                foreach (Cell _c in grid)
                {
                    _c.SetValue("!");
                }
                Console.WriteLine("Not implemented");
            }
        }

        /// <summary>
        /// A static method to setup the generation algorithm.
        /// </summary>
        /// <param name="mazeGrid">The grid of cells that represents the maze.</param>
        protected abstract void Setup();

        /// <summary>
        /// Generates the next cell.
        /// </summary>
        /// <returns>False if no cell was gotten</returns>
        public abstract bool NextCell();

        /// <summary>
        /// Gets the String name for the class
        /// </summary>
        /// <returns>Name for the class</returns>
        public abstract String GetName();

        /// <summary>
        /// Clears all markings on grid
        /// </summary>
        public void ClearMarkings()
        {
            foreach (Cell _cell in grid)
            {
                _cell.SetCreated();
                _cell.SetValue("");
            }
        }

        protected void SetCurrCell(Cell _c)
        {
            if (currCell != null)
            {
                currCell.SetValue(currCell.Value.Replace("*", ""));
            }
            currCell = _c;
            if (currCell != null)
            {
                currCell.SetValue(currCell.Value.Insert(0, "*"));
            }
        }

        /// <summary>
        /// Randomly decides true or false
        /// </summary>
        /// <returns>Random bool value</returns>
        protected static bool GetRandBool()
        {
            return (rand.Next() % 2) == 1;
        }
    }
}
