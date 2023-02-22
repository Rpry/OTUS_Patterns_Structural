﻿namespace Flyweight.Solution
{
    public class Tree
    {
        private double X { get; set; }

        private double Y { get; set; }
        
        public TreeType Type { get; set; }

        public Tree(double x, double y, TreeType type)
        {
            X = x;
            Y = y;
            Type = type;
        }

        public void Draw(int canvas)
        {
            Type.Draw(canvas, X, Y);
        }
            
    }
}