using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public class Player
    {

        public NewMaze pMaze = new NewMaze();
        public static readonly char pChar = '♂';
        public static readonly char women = '♀';
        //public ConsoleKeyInfo pressBtn = Console.ReadKey(true);

        public void moveLeft(ref int x, ref int y)
        {
           // pMaze.MazeWalled = new Wall[NewMaze.MAZE_SIZE, NewMaze.MAZE_SIZE];
            //if (pressBtn.Key == ConsoleKey.A)
            //{
            //    //if (pMaze.MazeWalled[x - 1, y] is Room)
            //    //{
            //    //    x -= 1;
            //    //    SetPlayer(x, y);
            //    //}
            //}
        }
        
        public void moveRight(ref int x, ref int y)
        {
            //if (pressBtn.Key == ConsoleKey.D)
            //{
            //    //if (pMaze.MazeWalled[x + 1, y] is Room)
            //    //{
            //    //    x += 1;
            //    //    SetPlayer(x, y);
            //    //}
            //}
        }
        public void moveUp(ref int x, ref int y)
        {
            //if (pressBtn.Key == ConsoleKey.W)
            //{
            //    //if (pMaze.MazeWalled[y - 1, x] is Room)
            //    //{
            //    //    y -= 1;
            //    //    SetPlayer(x, y);
            //    //}
            //}
        }
        public void moveDown(ref int x, ref int y)
        {
            //if (pressBtn.Key == ConsoleKey.S)
            //{
            //    //if (pMaze.MazeWalled[x, y + 1] is Room)
            //    //{
            //    //    y += 1;
            //    //    SetPlayer(x, y);
            //    //}
            //}
        }
        //public void SetPlayer(int x, int y)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(Player.pChar);
        //}
    }
}
