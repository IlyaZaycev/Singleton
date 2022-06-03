using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public class NewMaze
    {
        public const int MAZE_SIZE = 9;
        //private InteriorWallBuilder intWall = new InteriorWallBuilder();
        //private OuterWallBuilder outWall = new OuterWallBuilder();

        //public OuterWallBuilder OutWallB
        //{
        //    get { return outWall; }
        //    set { outWall = value; }
        //}
        //public InteriorWallBuilder IntWallB
        //{
        //    get { return intWall; }
        //    set { intWall = value; }
        //}
        public int[,] mazePattern = new int[MAZE_SIZE, MAZE_SIZE]
            {
                {3,1,1,1,1,1,1,1,3},
                {3,0,0,0,0,0,0,0,3},
                {3,0,4,2,2,0,2,2,3},
                {3,0,0,0,4,0,0,0,3},
                {3,2,2,0,4,2,4,2,3},
                {3,0,4,0,0,0,0,0,3},
                {3,0,0,0,0,4,2,2,3},
                {3,0,2,4,0,0,0,0,3},
                {3,1,1,1,1,1,1,1,3}
            };
        private Wall[,] mazeWalled = new Wall[MAZE_SIZE, MAZE_SIZE];
        public Wall[,] MazeWalled
        {
            get { return MazeWalled; }
            set
            {
                for (int i = 0; i < MAZE_SIZE; i++)
                {
                    for (int j = 0; j < MAZE_SIZE; j++)
                    {
                        InteriorWallBuilder iWB = new InteriorWallBuilder();
                        iWB.SetVertIntWall('│');
                        iWB.SetHorizIntWall('─');
                        iWB.SetHP(3);
                        Wall iWall = iWB.CreateWall();
                        OuterWallBuilder oWB = new OuterWallBuilder();
                        oWB.SetHorizOutWall('═');
                        oWB.SetVertOutWall('║');
                        Wall oWall = oWB.CreateWall();
                        Wall room = new Room(' ');
                        if (mazePattern[i, j] == 0) { mazeWalled[i, j] = room; }
                        if (mazePattern[i, j] == 1) { mazeWalled[i, j] = oWall; }
                        if (mazePattern[i, j] == 3) { mazeWalled[i, j] = oWall; }
                        if (mazePattern[i, j] == 2)
                        {
                            mazeWalled[i, j] = iWall;
                        }
                        if (mazePattern[i, j] == 4)
                        {
                            mazeWalled[i, j] = iWall;
                        }
                    }
                }
            }
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < MAZE_SIZE; i++)
            {
                for (int j = 0; j < MAZE_SIZE; j++)
                {
                    if (mazePattern[i, j] == 1 || mazePattern[i, j] == 2)
                        result += mazeWalled[i, j].HorWall;
                    else if (mazePattern[i, j] == 3 || mazePattern[i, j] == 4)
                        result += mazeWalled[i, j].VertWall;
                    else if (mazePattern[i, j] == 0)
                        result += mazeWalled[i, j].RoomChar;
                }
                result += "\n";
            }
            return result;
        }
    }
}
