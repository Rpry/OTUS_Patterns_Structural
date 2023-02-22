namespace Flyweight.Solution
{
    public class TreeType
    {
        public string Name { get; set; }
        
        public int Colour { get; set; }
        
        public int Texture { get; set; }

        public TreeType(string name, int colour, int texture)
        {
            Name = name;
            Colour = colour;
            Texture = texture;
        }
        
        public void Draw(int canvas, double x, double y)
        {
            // используем Colour, Texture, x, y,
        }
    }
}