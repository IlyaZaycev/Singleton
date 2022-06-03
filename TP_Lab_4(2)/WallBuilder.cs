using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_4_2_
{
    public abstract class WallBuilder
    {
        private Wall wall = new Wall();

        public  Wall Wall
        {
            get { return wall; }
            set { wall = value; }
        }

        public abstract Wall CreateWall();
        public abstract void SetHP(uint hp);
        public abstract void SetVertIntWall(char a);
        public abstract void SetHorizIntWall(char b);
        public abstract void SetVertOutWall(char a);
        public abstract void SetHorizOutWall(char b);
    }
}
