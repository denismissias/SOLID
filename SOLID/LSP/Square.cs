﻿namespace SOLID.LSP
{
    public class Square : Rectangle
    {
        public Square(int side)
        {
            Width = Height = side;
        }

        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}
