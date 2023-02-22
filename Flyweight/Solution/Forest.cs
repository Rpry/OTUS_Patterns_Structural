using System.Collections.Generic;

namespace Flyweight.Solution
{
    public class Forest
    {
        private List<Tree> _trees;


        public Forest()
        {
            _trees = new List<Tree>();
        }
        
        public void PlantTree(int x, int y, string name, int colour, int texture)
        {
            var treeType = TreeTypeFactory.GetTreeType(name, colour, texture);
            var tree = new Tree(x, y, treeType);
            _trees.Add(tree);
        }

        public void Draw(int canvas)
        {
            foreach (var tree in _trees)
            {
                tree.Draw(canvas);
            }
        }
    }
}