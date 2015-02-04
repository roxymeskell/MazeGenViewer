﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGeneration
{
    /// <summary>
    /// Class to generate a maze using the Growing Tree algorithm
    /// Extends MazeGeneration
    /// About algorithm --
    /// This is a general algorithm, capable of creating Mazes of different textures. It requires storage up to the size of the Maze. Each time you carve a cell, add that cell to a list. Proceed by picking a cell from the list, and carving into an unmade cell next to it. If there are no unmade cells next to the current cell, remove the current cell from the list. The Maze is done when the list becomes empty. The interesting part that allows many possible textures is how you pick a cell from the list. For example, if you always pick the most recent cell added to it, this algorithm turns into the recursive backtracker. If you always pick cells at random, this will behave similarly but not exactly to Prim's algorithm. If you always pick the oldest cells added to the list, this will create Mazes with about as low a "river" factor as possible, even lower than Prim's algorithm. If you usually pick the most recent cell, but occasionally pick a random cell, the Maze will have a high "river" factor but a short direct solution. If you randomly pick among the most recent cells, the Maze will have a low "river" factor but a long windy solution.
    /// </summary>
    class GrowingTree : MazeAlgorithm
    {
        protected override void Setup()
        {
            throw new NotImplementedException();
        }

        public override bool NextCell()
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            return "Growing Tree";
        }
    }
}
