using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGeneration
{
    /// <summary>
    /// Class to generate a maze using Krusakal's Algorithm
    /// Extends MazeGeneration
    /// About algorithm --
    /// Doesn't "grow" the Maze like a tree, but rather carves passage segments all over the Maze at random,
    /// but yet still results in a perfect Maze in the end. 
    /// Requires storage proportional to the size of the Maze,
    /// along with the ability to enumerate each edge or wall between cells in the Maze in random order
    /// (which usually means creating a list of all edges and shuffling it randomly).
    /// 
    /// Label each cell with a unique id, then loop over all the edges in random order.
    /// For each edge, if the cells on either side of it have different id's, then erase the wall,
    ///     and set all the cells on one side to have the same id as those on the other.
    /// If the cells on either side of the wall already have the same id, then there already exists some path between those two cells,
    ///     so the wall is left alone so as to not create a loop. 
    /// </summary>
    class Kruskal : MazeAlgorithm
    {
        readonly int X_COOR_0 = 0, Y_COOR_0 = 1, X_COOR_1 = 2, Y_COOR_1 = 3;

        List<int[]> edges;

        protected override void Setup()
        {
            
            int id = 0;
            foreach (Cell _cell in grid)
            {
                _cell.SetCreated();
                _cell.SetValue(id.ToString());
                _cell.CloseWalls();
                id++;
            }

            // Add edges to list
            edges = new List<int[]>(grid.GetLength(0) * grid.GetLength(1) * 2);
            for (int _x = 0; _x < grid.GetLength(0); _x++ )
            {
                for (int _y = 0; _y < grid.GetLength(1); _y++)
                {
                    if (_x < grid.GetLength(0) - 1)
                        edges.Add(new int[] { _x, _y, _x + 1, _y });
                    if (_y < grid.GetLength(1) - 1)
                        edges.Add(new int[] { _x, _y, _x, _y + 1 });
                }
            }

                //throw new NotImplementedException();
        }

        public override bool NextCell()
        {
            // Return false if no more edges
            if (edges.Count == 0)
                return false;

            // Get random edge
            int _e = rand.Next(edges.Count);
            int[] _edge = edges.ElementAt(_e);
            edges.RemoveAt(_e);

            // Check if cells match, if not, delete wall and merge sets
            if (!grid[_edge[X_COOR_0], _edge[Y_COOR_0]].Value.Equals(grid[_edge[X_COOR_1], _edge[Y_COOR_1]].Value))
            {
                // Delete wall
                if (_edge[X_COOR_0] == _edge[X_COOR_1])
                    grid[_edge[X_COOR_0], _edge[Y_COOR_0]].SetLowerWall(false);
                else
                    grid[_edge[X_COOR_0], _edge[Y_COOR_0]].SetRightWall(false);
                // Merge sets
                String _preID = grid[_edge[X_COOR_1], _edge[Y_COOR_1]].Value;
                foreach (Cell _cell in grid)
                    if (_cell.Value.Equals(_preID))
                        _cell.SetValue(grid[_edge[X_COOR_0], _edge[Y_COOR_0]].Value);
            }

            return true;

            //throw new NotImplementedException();
        }

        public override string GetName()
        {
            return "Kruskal's Algorithm";
        }
    }
}
