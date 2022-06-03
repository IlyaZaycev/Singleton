using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public abstract class MazeBuilder
    {
        protected const int MAZE_SIZE = 15;
        private Maze maze = new Maze();
        public Maze Maze
        {
            get { return maze; }
            set { maze = value; }
        }
        public abstract void CreateMaze();
        public abstract void SetCharsOuterWall(char ohw, char ovw);
        public abstract void SetCharsInteriorWall(char ihw, char ivw);
        //public abstract void SetInteriorWallHP(int num);
    }
}
