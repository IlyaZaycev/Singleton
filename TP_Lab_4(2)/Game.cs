using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace TP_Lab_4_2_
{
    class Game
    {
        public int[,] mazeForS = new int[NewMaze.MAZE_SIZE, NewMaze.MAZE_SIZE]
        {
                {3,3,3,3,3,3,3,3,3 },
                {1,0,0,0,2,0,0,0,1 },
                {1,0,4,0,2,4,0,2,1 },
                {1,0,2,0,0,0,0,4,1 },
                {1,0,2,4,4,0,0,0,1 },
                {1,0,0,0,2,0,4,0,1 },
                {1,0,2,0,4,0,2,0,1 },
                {1,0,2,0,2,0,2,0,1 },
                {3,3,3,3,3,3,3,3,3 }
        };

        public Player player = new Player();
        public NewMaze newMaze = new NewMaze();
        public Game game;
       // ConsoleKeyInfo restartBtn = Console.ReadKey(true);
        /*public Game newGame
        {
            get
            {
                if (game == null)
                {
                    game = new Game();
                    newMaze.MazeWalled = new Wall[NewMaze.MAZE_SIZE, NewMaze.MAZE_SIZE];
                    Console.WriteLine(newMaze.ToString());
                }
                return game;
            }
        }*/
        public Game CreateGame()
        {
            //var a = newMaze.MazeWalled[1, 1];
            if (game == null)
            {
                game = new Game();
                newMaze.MazeWalled = new Wall[NewMaze.MAZE_SIZE, NewMaze.MAZE_SIZE];
                //Console.WriteLine(newMaze.ToString());
            }
            return game;
        }

        public void StartGame()
        {

            //Console.
            //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.WriteLine(newMaze.ToString());
            SetWomen();
            SetPlayer(1, 1);
            
            var x = Console.CursorLeft - 1;
            var y = Console.CursorTop;
            while (x * y != 49)
            //{
            //Here:
            //for (int i = 0; i < 10; i++)
            {
                
                var pressBtn = Console.ReadKey(true);
                if (pressBtn.Key == ConsoleKey.A)
                {
                    //Console.WriteLine(newMaze.ToString());
                    if (mazeForS[x - 1, y] == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(newMaze.ToString());
                        x -= 1;
                        SetPlayer(x, y);
                        SetWomen();
                    }
                    //player.moveUp(ref x, ref y);
                    //Console.Clear();
                    //continue;
                }
                //if (x != 8 && y != 8) goto Here;
                if (pressBtn.Key == ConsoleKey.D)
                {
                    //Console.WriteLine(newMaze.ToString());

                    if (mazeForS[x + 1, y] == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(newMaze.ToString());
                        x += 1;
                        SetPlayer(x, y);
                        SetWomen();
                        //int rand = newMaze.mazeForS[x+1,y];
                    }
                    //player.moveRight(ref x, ref y);D
                    //Console.Clear();
                    // continue;
                }
                //if (x != 8 && y != 8) goto Here;
                if (pressBtn.Key == ConsoleKey.W)
                {
                    //Console.WriteLine(newMaze.ToString());
                    if (mazeForS[x, y - 1] == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(newMaze.ToString());
                        y -= 1;
                        SetPlayer(x, y);
                        SetWomen();
                    }
                    //player.moveLeft(ref x, ref y);
                    //Console.Clear();
                    // continue;
                }
                //if (x != 8 && y != 8) goto Here;

                if (pressBtn.Key == ConsoleKey.S)
                {
                    //Console.WriteLine(newMaze.ToString());

                    if (mazeForS[x, y + 1] == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(newMaze.ToString());
                        y += 1;
                        SetPlayer(x, y);
                        SetWomen();
                    }

                    //  continue;
                    //player.moveDown(ref x, ref y);
                    //Console.Clear();

                }
                if (pressBtn.Key == ConsoleKey.R)
                {
                    RestartGame();
                }

                if (x * y == 49)
                    EndGame();
                //if (x != 8 && y != 8) goto Here;

            }//}
        }
        public void SetPlayer(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Player.pChar);
        }
        public void SetWomen()
        {
            Console.SetCursorPosition(7, 7);
            Console.Write(Player.women);
        }
        public void RestartGame()
        {
            Console.Clear();
            StartGame();
        }
        public void EndGame()
        {
            //Console.SetCursorPosition(NewMaze.MAZE_SIZE, NewMaze.MAZE_SIZE);
            Console.SetCursorPosition(7, 7);
            Console.Write("♥");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Congrats!");
        }
    }
}
