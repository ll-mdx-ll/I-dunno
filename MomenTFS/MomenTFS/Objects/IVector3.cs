﻿namespace MomenTFS.Objects
{
    public class IVector3
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public IVector3(int x, int y, int z) {
            X = x;
            Y = y;
            Z = z;
        }


        public override string ToString() {
            return $"[{X}, {Y}, {Z}]";
        }
    }
}
