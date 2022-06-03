using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public class InteriorWallBuilder : WallBuilder
    {
        public InteriorWallBuilder()
        {
            Wall = new InteriorWall();
        }
        public override Wall CreateWall()
        {
            return Wall;
        }

        public override void SetHorizIntWall(char a)
        {
            Wall.HorWall = a;
        }

        public override void SetHorizOutWall(char b)
        {
        }

        public override void SetVertIntWall(char b)
        {
            Wall.VertWall = b;
        }

        public override void SetVertOutWall(char a)
        {
        }
        public override void SetHP(uint hp)
        {
            Wall.HP = 3;
        }
    }
}
