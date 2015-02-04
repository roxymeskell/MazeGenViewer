using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGeneration
{
    public class Cell
    {
        readonly int x, y;
        String value;
        bool xWall, yWall, created, viewed;

        public String Value
        {
            get { return value; }
        }
        public bool Viewed
        {
            get { return viewed; }
        }
        public bool Created
        {
            get { return created; }
        }
        public bool HasRightWall
        {
            get { return xWall; }
        }
        public bool HasLowerWall
        {
            get { return yWall; }
        }
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

        public Cell(int _x, int _y)
        {
            x = _x;
            y = _y;
            value = "";
            xWall = false;
            yWall = false;
            created = false;
        }

        public Cell(int _x, int _y, String _value)
        {
            x = _x;
            y = _y;
            value = _value;
            xWall = false;
            yWall = false;
            created = false;
            viewed = false;
        }

        public void SetValue(String _value)
        {
            value = _value;
        }

        public void SetVeiwed(bool _viewed)
        {
            viewed = _viewed;
        }

        public void CloseWalls()
        {
            xWall = true;
            yWall = true;
        }

        public void OpenWalls()
        {
            xWall = false;
            yWall = false;
        }

        public void SetRightWall(bool _value)
        {
            xWall = _value;
        }

        public void SetLowerWall(bool _value)
        {
            yWall = _value;
        }

        public void SetCreated()
        {
            created = true;
        }

        public void SetUncreated()
        {
            created = false;
        }
    }
}
