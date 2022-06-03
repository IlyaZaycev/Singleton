using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public class MazeBuilder1 : MazeBuilder
    {
        public override void CreateMaze()
        {
            Maze.MazePattern = new char[MAZE_SIZE, MAZE_SIZE];
        }
        public override void SetCharsOuterWall(char ohw, char ovw)
        {
            Maze.OuterWall.HorWall = ohw;
            Maze.OuterWall.VertWall = ovw;
        }
        public override void SetCharsInteriorWall(char ihw, char ivw)
        {
            Maze.InteriorWall.HorWall = ihw;
            Maze.InteriorWall.VertWall = ivw;
        }
        //public override void SetInteriorWallHP(int num)
        //{
        //    Maze.InteriorWall.HP = num;
        //}
        public override string ToString()
        {
            string picture = "";
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    picture += Convert.ToString(Maze.MazePattern[i, j]);
                }
                picture += "\n";
            }
            return picture;
        }
    }
}