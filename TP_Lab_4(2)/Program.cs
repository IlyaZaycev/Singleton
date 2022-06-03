using System;
using System.Text;

namespace TP_Lab_4_2_
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region РЕАЛИЗАЦИЯ ЧЕРЕЗ MAZEBUILDER
            //MazeBuilder1 mazeBuilder1 = new MazeBuilder1();
            //mazeBuilder1.SetCharsOuterWall('5', '7');
            //mazeBuilder1.SetCharsInteriorWall('6', '8');
            //mazeBuilder1.SetInteriorWallHP(90);
            //mazeBuilder1.CreateMaze();
            //Console.WriteLine(mazeBuilder1.ToString());
            #endregion
            
            #region РЕАЛИЗАЦИЯ ЧЕРЕЗ WALLBUILDER
            NewMaze newMaze = new NewMaze();
            /*newMaze.MazeWalled = new Wall[NewMaze.MAZE_SIZE, NewMaze.MAZE_SIZE];
            Console.WriteLine(newMaze.ToString());*/
            #endregion

            #region РЕАЛИЗАЦИЯ ЧЕРЕЗ GAME
            Game game = new Game();
            game.CreateGame();
            //Console.WriteLine(newMaze.ToString());
            game.StartGame();
            #endregion

        }
    }
}

