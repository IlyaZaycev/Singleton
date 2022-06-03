using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public class Maze
    {
        private OuterWall outerWall = new OuterWall();
        public OuterWall OuterWall
        {
            get { return outerWall; }
            set { outerWall = value; }
        }
        private InteriorWall interiorWall = new InteriorWall();
        public InteriorWall InteriorWall
        {
            get { return interiorWall; }
            set { interiorWall = value; }
        }
        private char[,] mazePattern = new char[15,15]
            {
                {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'},
                {'3','4','2','2','2','2','2','2','2','2','2','2','2','2','3'},
                {'3','2','4','2','2','2','2','2','2','2','2','2','2','2','3'},
                {'3','2','2','4','2','2','2','2','2','2','2','2','2','2','3'},
                {'3','2','2','2','4','2','2','2','2','2','2','4','2','2','3'},
                {'3','2','2','2','2','4','2','2','2','2','2','2','2','2','3'},
                {'3','2','2','2','2','2','4','2','2','2','2','2','2','2','3'},
                {'3','2','2','2','2','2','2','4','2','2','2','2','2','2','3'},
                {'3','2','2','2','2','2','2','2','4','2','2','2','2','2','3'},
                {'3','2','2','2','2','2','2','2','2','4','2','2','2','2','3'},
                {'3','2','2','2','2','2','2','2','2','2','4','2','2','2','3'},
                {'3','2','2','4','2','2','2','2','2','2','2','4','2','2','3'},
                {'3','2','2','2','2','2','2','2','2','2','2','2','4','2','3'},
                {'3','2','2','2','2','2','2','2','2','2','2','2','2','4','3'},
                {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'}
            };
        public char[,] MazePattern
        {
            get { return mazePattern; }
            set 
            {
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        if (mazePattern[i, j] == '1') { mazePattern[i, j] = OuterWall.HorWall; }
                        if (mazePattern[i, j] == '3') { mazePattern[i, j] = OuterWall.VertWall; }
                        if (mazePattern[i, j] == '2') { mazePattern[i, j] = InteriorWall.HorWall; }
                        if (mazePattern[i, j] == '4') { mazePattern[i, j] = InteriorWall.VertWall; }
                    }
                }
            }
        }

    }
}
